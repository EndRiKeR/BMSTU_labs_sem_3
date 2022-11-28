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

        /*List<int> _countOfDocs = new List<int>();
        List<int> _countOfCerf = new List<int>();
        List<int> _countOfSpec = new List<int>();*/

        int _curId = 0;
        string _curTable = "";
        Moves _move = Moves.None;



        Limits limits = new Limits();

        public Form1()
        {
            InitializeComponent();

            _docForm.EndEvent += OkInDoc;

            limits = _dataBase.GetIdLimits();

        }

        private void ButtonPressed(object sender, EventArgs e)
        {
            try
            {
                _curId = Convert.ToInt16(id_catcher_txt.Text);
                _curTable = tables_names_cb.Text;
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
            catch (Exception ex)
            {
                MessageBox.Show("Uncorrect ID Format");
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
    }
}
