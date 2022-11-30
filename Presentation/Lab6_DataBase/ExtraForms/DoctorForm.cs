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
using Presentation.Enums;

namespace Presentation
{
    public partial class DoctorForm : Form
    {
        private DataBase _db = new DataBase();

        private List<Specialization> _specsId = new();
        private Doctor _oldDoc = new Doctor();

        private bool _changesSaved = false;
        private Moves _move = Moves.None;

        public event Action<Moves> EndEvent;

        public DoctorForm()
        {
            InitializeComponent();

            docForm_specId_udn.Minimum = 0;
            docForm_docId_txt.ReadOnly = true;
            docForm_docName_txt.Visible = true;
        }

        public void SetupAndStart(Moves move, int id)
        {
            _changesSaved = false;
            _move = move;

            if (_move != Moves.Del)
            {
                SetupForm(id);
                this.Show();
            }
            else
            {
                SetupDelete(id);
            }
        }

        private void SetupDelete(int id)
        {
            string message = $"Are you sure to delete entity eith Id:{id}";
            string caption = "Deleting entity";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            // Displays the MessageBox.
            if (MessageBox.Show(message, caption, buttons) == DialogResult.Yes)
            {
                _changesSaved = true;
                _oldDoc = new();
                _oldDoc.Id = id;
            }
            EndEvent?.Invoke(_move);
        }

        private void SetupForm(int id)
        {
            

            if (_move == Moves.Change)
            {
                Doctor doc = _db.GetDoctor(id);

                docForm_docId_txt.Visible = true;
                docForm_docId_lbl.Visible = true;
                docForm_docName_txt.Text = doc.Name;
                docForm_specId_udn.Value = doc.SpecializationId.Id;
                docForm_docId_txt.Text = $"{doc.Id}";

                _oldDoc = doc;
            }
            else
            {
                docForm_docId_txt.Visible = false;
                docForm_docId_lbl.Visible = false;
                docForm_docName_txt.Text = "";
                docForm_docId_txt.Text = "";
                docForm_specId_udn.Value = 1;
            }

            _specsId = _db.GetListOfSpecs();

            if (_specsId.Count() > 0)
                docForm_specId_udn.Maximum = _specsId.Max(x => x.Id);
            else
                docForm_specId_udn.Maximum = 0;
        }

        public Doctor GetData()
        {
            if (_changesSaved)
            {
                Doctor doc = new Doctor(_specsId.FirstOrDefault(x => x.Id == docForm_specId_udn.Value), docForm_docName_txt.Text);
                if (_move != Moves.Add)
                {
                    doc.Id = _oldDoc.Id;
                }
                return doc;
            }

            return new();

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (_specsId.Select(x => x.Id).Contains((int)docForm_specId_udn.Value))
            {
                _changesSaved = true;
                this.Hide();
                EndEvent?.Invoke(_move);
            }
            else
            {
                MessageBox.Show($"Uncorrect SpecId:\nFrom{_specsId.Min(x => x.Id)} to {_specsId.Max(x => x.Id)}");
            }
        }

        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EndEvent?.Invoke(Moves.None);
        }
    }
}

