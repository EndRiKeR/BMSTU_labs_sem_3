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

            setupComboBox();

        }

        private void ButtonPressed(object sender, EventArgs e)
        {
            int i = dataGridView1.SelectedCells.Count;
            if (dataGridView1.SelectedCells.Count != 1)
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

        private void doc_change_btn_Click(object sender, EventArgs e)
        {
            _docForm.SetupAndStart(Moves.Change, SetupNowLimits());
        }

        private void doc_del_btn_Click(object sender, EventArgs e)
        {

            _docForm.SetupAndStart(Moves.Del, SetupNowLimits());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tables_names_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //получить данные из бд
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            switch (tables_names_cb.Text)
            {
                case "Doctor":
                    createColumnsForDoctor();
                    break;
                case "Certificate":
                    createColumnsForCertificates();
                    break;
                case "Specialization":
                    createColumnsForSpecializations();
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

            dataGridView1.Columns.AddRange(new DataGridViewTextBoxColumn[] { docId, specId, name });
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

            dataGridView1.Columns.AddRange(new DataGridViewTextBoxColumn[] { cerfId, docId, description, date });
        }

        private void createColumnsForSpecializations()
        {
            DataGridViewTextBoxColumn specId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();

            specId.Name = "SpecId";
            specId.Width = 100;
            name.Name = "Name";
            name.Width = 100;

            dataGridView1.Columns.AddRange(new DataGridViewTextBoxColumn[] { specId, name });
        }

        private void setupComboBox()
        {
            tables_names_cb.Items.Clear();
            tables_names_cb.Items.AddRange(new string[] { "Doctor", "Certificate", "Specialization" });
        }

        private void setupTable()
        {

        }
    }
}
