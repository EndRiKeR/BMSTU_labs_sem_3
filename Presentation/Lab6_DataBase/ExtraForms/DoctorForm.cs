using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseModels.Entity;
using Core;

namespace Presentation
{
    public partial class DoctorForm : Form
    {

        private List<int> _docId = new List<int>();
        private List<int> _specId = new List<int>();

        private Doctor? _oldDoc;

        private bool _changesSaved = false;

        private Moves _move = Moves.None;

        public event Action<Moves> EndEvent;

        public DoctorForm()
        {
            InitializeComponent();
        }

        public void SetupAndStart(Moves move, Limits limit, Doctor doc = null)
        {
            if (move == Moves.Change)
                _oldDoc = doc;

            _docId = limit.DoctorsLimits;
            _specId = limit.SpecializationsLimits;

            _changesSaved = false;
            _move = move;

            SetupForm(limit);

            this.Show();
        }

        public void SetupForm(Limits limit)
        {
            docForm_docName_txt.Text = "";
            docForm_docName_txt.Enabled = (_move != Moves.Del);

            docForm_docId_txt.Text = "";
            docForm_docId_txt.Enabled = (_move == Moves.Del);

            docForm_specId_txt.Text = "";
            docForm_specId_txt.Enabled = (_move != Moves.Del);
        }

        public Doctor GetData()
        {
            //if (_changesSaved)
                //return new Doctor(Convert.ToInt32(docForm_docId_txt.Text),
                               // new Specialization(Convert.ToInt32(docForm_specId_txt.Text)),
                               // docForm_docName_txt.Text);

            return _oldDoc;

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            _changesSaved = true;
            this.Hide();
            EndEvent?.Invoke(_move);
        }

        private void docForm_docName_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
