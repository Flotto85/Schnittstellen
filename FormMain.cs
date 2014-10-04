using Schnittstellen.Model;
using Schnittstellen.Presenter;
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
    public partial class FormMain : Form
    {
        #region Fields and Properties
        Project m_loadedProject;
        ProjectExplorerPresenter m_explorerPresenter;

        public Project LoadedProject
        {
            get { return m_loadedProject; }
            set
            {
                if (m_loadedProject == value)
                    return;
                if (m_loadedProject != null)
                {
                    
                }
                m_loadedProject = value;
                if (m_loadedProject != null)
                {

                }
            }
        }
        #endregion

        #region Initialization
        public FormMain()
        {
            InitializeComponent();
            m_explorerPresenter = new ProjectExplorerPresenter(this.projectExplorerViewMain, m_loadedProject);
            m_explorerPresenter.NewDeviceRequested += m_explorerPresenter_NewDeviceRequested;
            
            InitDemo();
        }
        #endregion

        #region EventHandler
        private void m_explorerPresenter_NewDeviceRequested(object sender, Presenter.EventArgs.DeviceEventArgs e)
        {
            Device newDev = new Device("Neues Gerät");
            newDev.DeviceType = DeviceType.Other;
            FormAddEditDevice formNew = new FormAddEditDevice();
            EditDevicePresenter presenter = new EditDevicePresenter(formNew.EditDeviceView, newDev);
            formNew.ShowDialog();
            if (formNew.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                m_loadedProject.Devices.Add(newDev);
            }
        }
        #endregion

        #region Demo
        private void InitDemo()
        {
            LoadedProject = new Project();
            m_loadedProject.ProjectName = "Dummy";
            m_loadedProject.Devices.Add(new Device("Robot"));
            m_loadedProject.Devices.Add(new Device("SPS"));
            InterfaceDescription desc = new InterfaceDescription(m_loadedProject.Devices[0], m_loadedProject.Devices[1]);

            m_explorerPresenter.Project = m_loadedProject;
        }
        #endregion
    }
}
