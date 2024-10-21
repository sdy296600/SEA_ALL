﻿
namespace CoFAS.NEW.MES.Core
{
    partial class Base_textbox
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Control_Name = new DevExpress.XtraEditors.LabelControl();
            this._SearchText = new CoFAS.NEW.MES.Core.ucTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(142)))), ((int)(((byte)(172)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.AutoSize = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this._SearchText);
            this.panelControl2.Controls.Add(this.Control_Name);
            this.panelControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(300, 26);
            this.panelControl2.TabIndex = 3;
            // 
            // Control_Name
            // 
            this.Control_Name.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Control_Name.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Control_Name.Appearance.ForeColor = System.Drawing.Color.White;
            this.Control_Name.Appearance.Options.UseBackColor = true;
            this.Control_Name.Appearance.Options.UseFont = true;
            this.Control_Name.Appearance.Options.UseForeColor = true;
            this.Control_Name.Appearance.Options.UseTextOptions = true;
            this.Control_Name.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Control_Name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Control_Name.Dock = System.Windows.Forms.DockStyle.Left;
            this.Control_Name.Location = new System.Drawing.Point(0, 0);
            this.Control_Name.Name = "Control_Name";
            this.Control_Name.Size = new System.Drawing.Size(100, 26);
            this.Control_Name.TabIndex = 0;
            // 
            // _SearchText
            // 
            this._SearchText.AutoSize = true;
            this._SearchText.CancelButton = null;
            this._SearchText.CommandButton = null;
            this._SearchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._SearchText.EditMask = "";
            this._SearchText.Location = new System.Drawing.Point(100, 0);
            this._SearchText.Margin = new System.Windows.Forms.Padding(0);
            this._SearchText.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._SearchText.MaxLength = 0;
            this._SearchText.Name = "_SearchText";
            this._SearchText.NumText = "";
            this._SearchText.PasswordChar = '\0';
            this._SearchText.ReadOnly = false;
            this._SearchText.Size = new System.Drawing.Size(200, 26);
            this._SearchText.TabIndex = 1;
            this._SearchText.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._SearchText.ToolTipt = "";
            this._SearchText.UseMaskAsDisplayFormat = false;
            // 
            // Base_textbox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelControl2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Base_textbox";
            this.Size = new System.Drawing.Size(300, 26);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl Control_Name;
        private ucTextEdit _SearchText;
    }
}