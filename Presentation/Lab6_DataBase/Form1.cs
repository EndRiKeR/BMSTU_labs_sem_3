using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using DataBaseContext;
using DataBaseModels.Entity;
using Presentation;
using Presentation.Enums;

namespace Lab6_DataBase
{
    // Ljk,fdbnm gjkt dhfxe - ЗП - поле врача
    // И посчитаем среднюю стоимость врачей данной специализации
    //
    //

    public partial class Form1 : Form
    {
        DataBase _dataBase = new DataBase();

        CertificateForm _cerfForm = new CertificateForm();
        DoctorForm _docForm = new DoctorForm();
        SpecializationForm _specForm = new SpecializationForm();

        Moves _move = Moves.None;
        Tables _table = Tables.None;

        public Form1()
        {
            InitializeComponent();

            EnableButtons(false);

            //впервые инициализируем базу
            using (var context = new Context())
            {
                context.ClearDatabase();
            }

            //Заполняем ее тест данными
            InitDbWithTestData();

            //Добавляем в эвенты реакции на всякое
            _docForm.EndEvent += OkInDoc;

            //Инициализация объектов формы
            setupComboBox();
            

            //Доп вопросы
            EnableQuestButtons(false);
            lastCerfForDoc_btn.Enabled = true;


        }

        public async void InitDbWithTestData()
        {
            await _dataBase.InitializeWithTestData();

            EnableButtons(true);
            updateTable();
        }

        private void ButtonPressed(object sender, EventArgs e)
        {
            if ((dataTable.SelectedCells.Count != 1) && (dataTable.Rows.Count > 0))
            {
                MessageBox.Show("Выбрано больше одной ячейки таблицы или ни одной");
            }
            else
            {
                int id = 0;

                if (dataTable.Rows.Count > 0)
                    id = Convert.ToInt32(dataTable.Rows[dataTable.CurrentCell.RowIndex].Cells[0].Value);

                switch (tables_names_cb.Text)
                {
                    case "Doctor":
                        _table = Tables.Doctors;
                        break;
                    case "Certificate":
                        _table = Tables.Certificates;
                        break;
                    case "Specialization":
                        _table = Tables.Specializations;
                        break;
                    default:
                        _table = Tables.None;
                        break;
                }

                switch (((Button)sender).Text)
                {
                    case "Add":
                        _move = Moves.Add;
                        WorkWithEntity(_move, id);
                        break;
                    case "Change":
                        _move = Moves.Change;
                        WorkWithEntity(_move, id);
                        break;
                    case "Delete":
                        _move = Moves.Del;
                        WorkWithEntity(_move, id);
                        break;
                }
            }
        }

        private void SetupDocForm()
        {
            _docForm = new DoctorForm();
            _docForm.EndEvent += OkInDoc;
        }

        private void SetupCerfForm()
        {
            _cerfForm = new CertificateForm();
            _cerfForm.EndEvent += OkInCerf;
        }

        private void SetupSpecForm()
        {
            _specForm = new SpecializationForm();
            _specForm.EndEvent += OkInSpec;
        }

        private void WorkWithEntity(Moves move, int id)
        {

            if (move != Moves.None)
                EnableButtons(false);

            try
            {
                switch (_table)
                {
                    case Tables.Doctors:
                        SetupDocForm();
                        _docForm.SetupAndStart(move, id);
                        break;
                    case Tables.Specializations:
                        SetupSpecForm();
                        _specForm.SetupAndStart(move, id);
                        break;
                    case Tables.Certificates:
                        SetupCerfForm();
                        _cerfForm.SetupAndStart(move, id);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void EnableButtons(bool enable)
        {
            add_btn.Enabled = enable;
            change_btn.Enabled = enable;
            del_btn.Enabled = enable;
        }

        private async void OkInDoc(Moves move)
        {
            switch (move)
            {
                case Moves.Add:
                    await _dataBase.AddToDoctors(_docForm.GetData());
                    break;
                case Moves.Change:
                    await _dataBase.ChangeDoctor(_docForm.GetData());
                    break;
                case Moves.Del:
                    await _dataBase.DeleteDoctor(_docForm.GetData().Id);
                    break;
                default:
                    break;
            }

            EnableButtons(true);
            updateTable();
        }

        private async void OkInCerf(Moves move)
        {
            switch (move)
            {
                case Moves.Add:
                    await _dataBase.AddToCertificates(_cerfForm.GetData());
                    break;
                case Moves.Change:
                    await _dataBase.ChangeCertificates(_cerfForm.GetData());
                    break;
                case Moves.Del:
                    await _dataBase.DeleteCertificate(_cerfForm.GetData().Id);
                    break;
                default:
                    break;
            }

            EnableButtons(true);
            updateTable();
        }

        private async void OkInSpec(Moves move)
        {
            switch (move)
            {
                case Moves.Add:
                    await _dataBase.AddToSpecializations(_specForm.GetData());
                    break;
                case Moves.Change:
                    await _dataBase.ChangeSpecialization(_specForm.GetData());
                    break;
                case Moves.Del:
                    await _dataBase.DeleteSpecialization(_specForm.GetData().Id);
                    break;
                default:
                    break;
            }

            EnableButtons(true);
            updateTable();
        }

        private void tables_names_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTable();

            EnableQuestButtons(false);

            switch (tables_names_cb.Text)
            {
                case "Doctor":
                    lastCerfForDoc_btn.Enabled = true;
                    break;
                case "Certificate":
                    SpecByCerf.Enabled = true;
                    break;
                case "Specialization":
                    docInSpec_btn.Enabled = true;
                    lastCheck_btn.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Uncorrect Table Name");
                    break;
            }

        }

        private void updateTable()
        {
            dataTable.Rows.Clear();
            dataTable.Columns.Clear();

            switch (tables_names_cb.Text)
            {
                case "Doctor":
                    List<Doctor> docs = _dataBase.GetListOfDocs();
                    createColumnsForDoctor();
                    docs.Sort((x, y) => x.Id.CompareTo(y.Id));
                    foreach (var doc in docs) dataTable.Rows.Add(new string[] { $"{doc.Id}", $"{doc.SpecializationId}", $"{doc.Name}", $"{doc.Pay}"});
                    break;
                case "Certificate":
                    List<Certificate> cerfs = _dataBase.GetListOfCerfs();
                    createColumnsForCertificates();
                    cerfs.Sort((x, y) => x.Id.CompareTo(y.Id));
                    foreach (var cerf in cerfs) dataTable.Rows.Add(new string[] { $"{cerf.Id}", $"{cerf.DoctorId}", $"{cerf.Description}", $"{cerf.Date}" });
                    break;
                case "Specialization":
                    List<Specialization> specs = _dataBase.GetListOfSpecs();
                    createColumnsForSpecializations();
                    specs.Sort((x, y) => x.Id.CompareTo(y.Id));
                    foreach (var spec in specs) dataTable.Rows.Add(new string[] { $"{spec.Id}", $"{spec.Name}" });
                    break;
                default:
                    MessageBox.Show("Uncorrect Table Name");
                    break;
            }

            if (dataTable.Rows.Count == 0)
            {
                change_btn.Enabled = false;
                del_btn.Enabled = false;
            }
            else
            {
                EnableButtons(true);
            }
        }

        private void createColumnsForDoctor()
        {
            DataGridViewTextBoxColumn docId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn specId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn pay = new DataGridViewTextBoxColumn();

            docId.Name = "DocId";
            docId.Width = 100;
            specId.Name = "SpecId";
            specId.Width = 100;
            name.Name = "Name";
            name.Width = 100;
            pay.Name = "Pay";
            pay.Width = 100;

            dataTable.Columns.AddRange(new DataGridViewTextBoxColumn[] { docId, specId, name, pay });
        }

        private void createColumnsForCertificates()
        {
            DataGridViewTextBoxColumn cerfId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn docId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();

            cerfId.Name = "CerfId";
            cerfId.Width = 100;
            docId.Name = "DocId";
            docId.Width = 100;
            description.Name = "Description";
            description.Width = 100;
            date.Name = "Date";
            date.Width = 100;

            dataTable.Columns.AddRange(new DataGridViewTextBoxColumn[] { cerfId, docId, description, date });
        }

        private void createColumnsForSpecializations()
        {
            DataGridViewTextBoxColumn specId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();

            specId.Name = "SpecId";
            specId.Width = 100;
            name.Name = "Name";
            name.Width = 100;

            dataTable.Columns.AddRange(new DataGridViewTextBoxColumn[] { specId, name });
        }

        private void setupComboBox()
        {
            tables_names_cb.Items.Clear();
            tables_names_cb.Items.AddRange(new string[] { "Doctor", "Certificate", "Specialization" });
        }

        private void EnableQuestButtons(bool enable)
        {
            docInSpec_btn.Enabled = enable;
            SpecByCerf.Enabled = enable;
            lastCerfForDoc_btn.Enabled = enable;
            lastCheck_btn.Enabled = enable;
        }

        private void docInSpec_btn_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("Я не могу дать ответ на вопрос, если данных банально НЕТ!");
                return;
            }

            int id = 0;

            if (dataTable.Rows.Count > 0)
                id = Convert.ToInt32(dataTable.Rows[dataTable.CurrentCell.RowIndex].Cells[0].Value);

            MessageBox.Show($"{_dataBase.HowManyDoctorsWithSpec(id)} - столько врачей владеют специальностью {_dataBase.GetSpecialization(id)}.");
        }

        private void SpecByCerf_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("Я не могу дать ответ на вопрос, если данных банально НЕТ!");
                return;
            }

            int id = 0;

            if (dataTable.Rows.Count > 0)
                id = Convert.ToInt32(dataTable.Rows[dataTable.CurrentCell.RowIndex].Cells[0].Value);

            MessageBox.Show($"{_dataBase.HowNamedSpecWithCertificate(id)} - название специализации, для которой был выдан сертификат {_dataBase.GetCertificate(id)}");
        }

        private void lastCerfForDoc_btn_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("Я не могу дать ответ на вопрос, если данных банально НЕТ!");
                return;
            }

            int id = 0;

            if (dataTable.Rows.Count > 0)
                id = Convert.ToInt32(dataTable.Rows[dataTable.CurrentCell.RowIndex].Cells[0].Value);

            DateTime dt = _dataBase.WhenWasArrivedLastCerfForDoc(id);
            if (dt.Date != new DateTime().Date)
                MessageBox.Show($"{dt} - дата последнего сертификата врача {_dataBase.GetDoctor(id)}");
            else
                MessageBox.Show("У данного врача нет сертификатов =(");
        }

        private void lastCHECK(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("Я не могу дать ответ на вопрос, если данных банально НЕТ!");
                return;
            }

            int id = 0;

            if (dataTable.Rows.Count > 0)
                id = Convert.ToInt32(dataTable.Rows[dataTable.CurrentCell.RowIndex].Cells[0].Value);

            double res = _dataBase.DoctorPayment(id);
            if (res != 0)
                MessageBox.Show($"Среднее - {res}");
            else
                MessageBox.Show("Ytn dhfxtq - ytn ltyzr =(");
        }


    }
}
