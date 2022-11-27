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

namespace Presentation
{
    public partial class DoctorForm : Form
    {

        private int _docId = 0;
        private int _specId = 0;
        private string _docName = "Anon";

        private bool _changesSaved = false;

        private Moves _move = Presentation.Moves.None;

        public event Action<Moves> EndEvent;

        public DoctorForm()
        {
            InitializeComponent();
        }

        public void SetupAndStart(Moves move, int docId = -1, int specId = 1, string docName = "Anon")
        {
            _docId = docId;
            _specId = specId;
            _docName = docName;

            _changesSaved = false;

            _move = move;

            SetupForm();

            this.Show();
        }

        public void SetupForm()
        {
            docForm_docId_nud.Maximum = _docId;
            docForm_docId_nud.Minimum = _docId;
            docForm_docId_nud.Value = _docId;
            docForm_docId_nud.InterceptArrowKeys = (_move != Moves.Add);

            //добавить проверку, что специализация существует
            docForm_specId_nud.Value = _specId;

            docForm_docName_txt.Text = _docName;
        }

        public Doctor GetData()
        {
            if (_changesSaved)
                return new Doctor((int)docForm_docId_nud.Value,
                                (int)docForm_specId_nud.Value,
                                docForm_docName_txt.Text);

            return new Doctor(_docId,
                                _specId,
                                _docName);

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            _changesSaved = true;
            this.Hide();
            EndEvent?.Invoke(_move);
        }
    }
}
