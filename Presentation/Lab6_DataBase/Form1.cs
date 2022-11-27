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

        int _countOfDocs = 0;
        int _countOfCerf = 0;
        int _countOfSpec = 0;

        public Form1()
        {
            InitializeComponent();
            /*CertificateForm _cerfForm = new CertificateForm();
            DoctorForm _docForm = new DoctorForm();
            SpecializationForm _specForm = new SpecializationForm();*/

            _docForm.EndEvent += OkInDoc;

            var limits = _dataBase.GetIdLimits();
            _countOfDocs = limits.DoctorsLimits;
            _countOfCerf = limits.CertificatesLimits;
            _countOfSpec = limits.SpecializationsLimits;

        }

        private void add_doc_btn_Click(object sender, EventArgs e)
        {
            //Вот тут добавить проверку на текущий ID врача
            _docForm.SetupAndStart(Moves.Add, ++_countOfDocs);
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
            _docForm.SetupAndStart(Moves.Add);
        }
    }
}
