using DataBaseModels.Entity;
using Presentation.Enums;
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

namespace Presentation
{
    public partial class CertificateForm : Form
    {
        private DataBase _db = new DataBase();

        private List<Doctor> _docsId = new();
        private Certificate _oldCertificate = new Certificate();

        private bool _changesSaved = false;
        private Moves _move = Moves.None;

        public event Action<Moves> EndEvent;

        public CertificateForm()
        {
            InitializeComponent();

            cerfForm_docId_udn.Minimum = 0;
            cerfForm_cerfId_txt.ReadOnly = true;
            cerfForm_cerfId_txt.Visible = true;
            cerfForm_cerfId_lbl.Visible = true;
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
                _oldCertificate = new();
                _oldCertificate.Id = id;
            }
            EndEvent?.Invoke(_move);
        }

        private void SetupForm(int id)
        {
            if (_move == Moves.Change)
            {
                Certificate cerf = _db.GetCertificate(id);

                cerfForm_cerfId_txt.Visible = true;
                cerfForm_cerfId_lbl.Visible = true;
                cerfForm_docId_udn.Value = cerf.DoctorId.Id;
                cerfForm_descr_txt.Text = cerf.Description;

                cerfForm_calendar.Update();

                _oldCertificate = cerf;
            }
            else
            {
                cerfForm_cerfId_txt.Visible = false;
                cerfForm_cerfId_lbl.Visible = false;
                cerfForm_docId_udn.Value = 1;
                cerfForm_descr_txt.Text = "";
            }

            _docsId = _db.GetListOfDocs();

            if (_docsId.Count() > 0)
                cerfForm_docId_udn.Maximum = _docsId.Max(x => x.Id);
            else
                cerfForm_docId_udn.Maximum = 0;
        }

        public Certificate GetData()
        {
            if (_changesSaved)
            {
                Certificate cerf = new Certificate(_docsId.FirstOrDefault(x => x.Id == cerfForm_docId_udn.Value), cerfForm_descr_txt.Text, cerfForm_calendar.TodayDate);
                if (_move != Moves.Add)
                {
                    cerf.Id = _oldCertificate.Id;
                }
                return cerf;
            }

            return new();

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (_docsId.Select(x => x.Id).Contains((int)cerfForm_docId_udn.Value))
            {
                _changesSaved = true;
                this.Hide();
                EndEvent?.Invoke(_move);
            }
            else
            {
                MessageBox.Show($"Uncorrect SpecId:\nFrom{_docsId.Min(x => x.Id)} to {_docsId.Max(x => x.Id)}");
            }
        }

        private void CerfForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EndEvent?.Invoke(Moves.None);
        }
    }
}
