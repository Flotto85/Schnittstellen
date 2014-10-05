using Schnittstellen.Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schnittstellen
{
    public partial class FormAddEditInterfaceDescription : Form
    {
        #region Fields and Properties
        public IEditInterfaceDescriptionPropertiesView EditInterfaceView
        {
            get { return this.editInterfaceDescriptionPropertiesView1; }
        }
        #endregion

        #region Initialization
        public FormAddEditInterfaceDescription()
        {
            InitializeComponent();
        }
        #endregion
    }
}
