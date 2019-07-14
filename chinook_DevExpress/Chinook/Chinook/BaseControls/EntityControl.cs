using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Chinook.BaseControls
{
    public partial class EntityControl : UserControl
    {
        public EntityControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
            
            if (ReadOnlyMode)
                ToReadOnly();
        }

        public virtual void ReadFromEntity(object entity)
        {
        }

        public virtual void WriteToEntity(object entity)
        {
        }

        [DefaultValue(false)]
        public bool ReadOnlyMode { get; set; }

        protected virtual void ToReadOnly()
        {
        }
    }
}
