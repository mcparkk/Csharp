using Chinook.BaseControls;
using MyLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Chinook.BaseForms
{
    public partial class EntityForm : Form
    {
        public EntityForm()
        {
            InitializeComponent();
        }

        #region virtual methods
        protected virtual EntityControl EntityControl
        {
            get;
        }

        protected virtual object Entity
        {
            get;
        }
        #endregion

        #region virtual methods
        protected virtual void OnSaveClick()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnDeleteClick()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region event handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            EntityControl.ReadFromEntity(Entity);


            PaintButtonsBeige();
        }

        private void PaintButtonsBeige()
        {
            List<Button> buttons = FindButtons3();
            foreach (Button button in buttons)
            {
                button.BackColor = Color.Beige;
            }
        }

        private List<Button> FindButtons()
        {
            List<Button> buttons = new List<Button>();

            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                if (control is Button)
                    buttons.Add((Button)control);
            }

            return buttons;
        }

        private List<Button> FindButtons2()
        {
            List<Button> buttons = new List<Button>();

            //Type type = this.GetType();
            Type type = typeof(EntityForm);
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo fi in fieldInfos)
            {
                if (fi.FieldType != typeof(Button))
                    continue;

                Button button = (Button)fi.GetValue(this);

                buttons.Add(button);
            }

            return buttons;
        }

        private List<Button> FindButtons3()
        {
            List<Button> buttons = new List<Button>();

            void FindButtonsCore(Control parent)
            {
                foreach (Control control in parent.Controls)
                {
                    if (control is Button)
                        buttons.Add((Button)control);

                    FindButtonsCore(control);
                }
            }

            FindButtonsCore(this);

            return buttons;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            EntityControl.WriteToEntity(Entity);

            OnSaveClick();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (WinformHelper.AskToDelete() == false)
                return;

            OnDeleteClick();

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion
    }
}
