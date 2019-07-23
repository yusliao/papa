﻿namespace PushServer
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ServiceProcess.ServiceInstaller serviceInstaller1;
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            serviceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceInstaller1
            // 
            serviceInstaller1.Description = "将订单信息推送到OMS系统中";
            serviceInstaller1.DisplayName = "推送服务";
            serviceInstaller1.ServiceName = "PushService";
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            //this.serviceProcessInstaller1.Password = "123";
            //this.serviceProcessInstaller1.Username = "Administrator";
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller1,
            serviceInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
    }
}