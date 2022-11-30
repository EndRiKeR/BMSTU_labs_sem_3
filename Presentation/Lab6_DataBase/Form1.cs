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

namespace Lab6_DataBase
{
    public partial class Form1 : Form
    {
        DataBase _dataBase = new DataBase();

        CertificateForm _cerfForm = new CertificateForm();
        DoctorForm _docForm = new DoctorForm();
        SpecializationForm _specForm = new SpecializationForm();

        Moves _move = Moves.None;

        public Form1()
        {
            InitializeComponent();

            //впервые инициализируем базу
            var context = new Context();

            //Заполняем ее тест данными
            _dataBase.InitializeWithTestData();

            //Добавляем в эвенты реакции на всякое
            _docForm.EndEvent += OkInDoc;

            //Инициализация объектов формы
            setupComboBox();
            updateTable();

        }

        private void ButtonPressed(object sender, EventArgs e)
        {
            int i = dataTable.SelectedCells.Count;
            if (dataTable.SelectedCells.Count != 1)
            {
                MessageBox.Show("Выбрано больше одной ячейки таблицы или ни одной");
            }
            else
            {
                switch (((Button)sender).Text)
                {
                    case "Add":
                        _move = Moves.Add;
                        break;
                    case "Change":
                        _move = Moves.Change;
                        break;
                    case "Delete":
                        _move = Moves.Del;
                        break;
                }

                DoMove();
            }
            
            
        }

        private void DoMove()
        {
            
        }

        private Limits SetupNowLimits()
        {
            return _dataBase.GetIdLimits();
        }

        private void add_doc_btn_Click(object sender, EventArgs e)
        {
            _docForm.SetupAndStart(Moves.Add, SetupNowLimits());
        }

        private void OkInDoc(Moves move)
        {
            switch (move)
            {
                case Moves.Add:
                    _dataBase.AddToDoctors(_docForm.GetData());
                    break;
                case Moves.Change:
                    _dataBase.ChangeDoctor(_docForm.GetData());
                    break;
                case Moves.Del:
                    _dataBase.DeleteDoctor(_docForm.GetData().Id);
                    break;
            }
        }

        private void tables_names_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTable();

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
                    foreach (var doc in docs) dataTable.Rows.Add(new string[] { $"{doc.Id}", $"{doc.SpecializationId}", $"{doc.Name}" });
                    break;
                case "Certificate":
                    List<Certificate> cerfs = _dataBase.GetListOfCerfs();
                    createColumnsForCertificates();
                    foreach (var cerf in cerfs) dataTable.Rows.Add(new string[] { $"{cerf.Id}", $"{cerf.DoctorId}", $"{cerf.Description}", $"{cerf.Date}" });
                    break;
                case "Specialization":
                    List<Specialization> specs = _dataBase.GetListOfSpecs();
                    createColumnsForSpecializations();
                    foreach (var spec in specs) dataTable.Rows.Add(new string[] { $"{spec.Id}", $"{spec.Name}" });
                    break;
                default:
                    MessageBox.Show("Uncorrect Table Name");
                    break;
            }
        }

        private void createColumnsForDoctor()
        {
            DataGridViewTextBoxColumn docId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn specId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();

            docId.Name = "DocId";
            docId.Width = 100;
            specId.Name = "SpecId";
            specId.Width = 100;
            name.Name = "Name";
            name.Width = 100;

            dataTable.Columns.AddRange(new DataGridViewTextBoxColumn[] { docId, specId, name });
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

        private void FillRowsWithDoctors(List<Doctor> docs)
        {
            foreach (var doc in docs)
            {
                dataTable.Rows.Add(new string[] { $"{doc.Id}", $"{doc.SpecializationId}", $"{doc.Name}" });
            }
        }

        private void setupComboBox()
        {
            tables_names_cb.Items.Clear();
            tables_names_cb.Items.AddRange(new string[] { "Doctor", "Certificate", "Specialization" });
        }
    }
}
