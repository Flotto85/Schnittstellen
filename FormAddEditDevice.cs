using Schnittstellen.Model;
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
    public partial class FormAddEditDevice : Form
    {
        #region Fields and Properties
        Device m_device;

        public IEditDeviceView EditDeviceView
        {
            get { return this.editDeviceView; }
        }

        public Device Device
        {
            get { return m_device; }
            set
            {
                if (m_device == value)
                    return;
                if (m_device != null)
                    editDeviceView.Bind(null);
                m_device = value;
                if (m_device != null)
                    editDeviceView.Bind(m_device);
            }
        }
        #endregion

        #region Initialization
        public FormAddEditDevice()
        {
            InitializeComponent();
        }
        #endregion
    }
}
