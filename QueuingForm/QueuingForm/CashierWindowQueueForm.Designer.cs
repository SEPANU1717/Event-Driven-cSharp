using System.ComponentModel;

namespace QueuingForm;

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
        listCashierQueue = new System.Windows.Forms.ListView();
        btnRefresh = new System.Windows.Forms.Button();
        btnNext = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // listCashierQueue
        // 
        listCashierQueue.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        listCashierQueue.Location = new System.Drawing.Point(266, 64);
        listCashierQueue.Name = "listCashierQueue";
        listCashierQueue.Size = new System.Drawing.Size(309, 366);
        listCashierQueue.TabIndex = 0;
        listCashierQueue.UseCompatibleStateImageBehavior = false;
        listCashierQueue.View = System.Windows.Forms.View.Tile;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnRefresh.Location = new System.Drawing.Point(67, 64);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new System.Drawing.Size(182, 47);
        btnRefresh.TabIndex = 1;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnNext
        // 
        btnNext.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnNext.Location = new System.Drawing.Point(67, 129);
        btnNext.Name = "btnNext";
        btnNext.Size = new System.Drawing.Size(182, 47);
        btnNext.TabIndex = 2;
        btnNext.Text = "Next";
        btnNext.UseVisualStyleBackColor = false;
        btnNext.Click += btnNext_Click;
        // 
        // CashierWindowQueueForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(649, 505);
        Controls.Add(btnNext);
        Controls.Add(btnRefresh);
        Controls.Add(listCashierQueue);
        Text = "CashierWindowQueue";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnNext;

    private System.Windows.Forms.Button btnRefresh;

    private System.Windows.Forms.ListView listCashierQueue;

    #endregion
}