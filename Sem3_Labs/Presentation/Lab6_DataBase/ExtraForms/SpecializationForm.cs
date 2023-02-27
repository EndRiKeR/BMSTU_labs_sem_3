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
    public partial class SpecializationForm : Form
    {
        private DataBase _db = new DataBase();

        //private List<Specialization> _specsId = new();
        private Specialization _oldSpec = new Specialization();

        private bool _changesSaved = false;
        private Moves _move = Moves.None;

        public event Action<Moves> EndEvent;

        public SpecializationForm()
        {
            InitializeComponent();

            specForm_specId_txt.ReadOnly = true;
            specForm_specId_txt.Visible = true;
            specForm_specId_lbl.Visible = true;
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
                _oldSpec = new();
                _oldSpec.Id = id;
            }
            EndEvent?.Invoke(_move);
        }

        private void SetupForm(int id)
        {
            if (_move == Moves.Change)
            {
                Specialization spec = _db.GetSpecialization(id);

                specForm_specId_txt.Visible = true;
                specForm_specId_lbl.Visible = true;
                specForm_specId_txt.Text = $"{spec.Id}";
                specForm_specName_txt.Text = spec.Name;

                _oldSpec = spec;
            }
            else
            {
                specForm_specId_txt.Visible = false;
                specForm_specId_lbl.Visible = false;
                specForm_specName_txt.Text = "";
            }
        }

        public Specialization GetData()
        {
            if (_changesSaved)
            {
                Specialization spec = new Specialization(specForm_specName_txt.Text);
                if (_move != Moves.Add)
                {
                    spec.Id = _oldSpec.Id;
                }
                return spec;
            }

            return new();

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            _changesSaved = true;
            this.Hide();
            EndEvent?.Invoke(_move);
        }

        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EndEvent?.Invoke(Moves.None);
        }

    }
}
