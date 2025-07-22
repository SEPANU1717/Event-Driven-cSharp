using System.ComponentModel;

namespace BasicQueuingCashier.Forms;

partial class CashierWindowQueueForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnRefresh = new System.Windows.Forms.Button();
        listCashierQueue = new System.Windows.Forms.ListView();
        btnnext = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnRefresh.Location = new System.Drawing.Point(23, 37);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new System.Drawing.Size(132, 42);
        btnRefresh.TabIndex = 0;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // listCashierQueue
        // 
        listCashierQueue.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        listCashierQueue.Location = new System.Drawing.Point(185, 37);
        listCashierQueue.Name = "listCashierQueue";
        listCashierQueue.Size = new System.Drawing.Size(300, 368);
        listCashierQueue.TabIndex = 1;
        listCashierQueue.UseCompatibleStateImageBehavior = false;
        listCashierQueue.View = System.Windows.Forms.View.List;
        // 
        // btnnext
        // 
        btnnext.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnnext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnnext.Location = new System.Drawing.Point(23, 97);
        btnnext.Name = "btnnext";
        btnnext.Size = new System.Drawing.Size(132, 42);
        btnnext.TabIndex = 2;
        btnnext.Text = "Next";
        btnnext.UseVisualStyleBackColor = false;
        btnnext.Click += btnnext_Click;
        // 
        // CashierWindowQueueForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(516, 446);
        Controls.Add(btnnext);
        Controls.Add(listCashierQueue);
        Controls.Add(btnRefresh);
        Text = "CashierWindowQueueForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnnext;

    private System.Windows.Forms.ListView listCashierQueue;

    private System.Windows.Forms.Button btnRefresh;

    #endregion
}