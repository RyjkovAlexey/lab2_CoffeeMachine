namespace lab2_CoffeeMachine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.currentBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.butCancelingOperation = new System.Windows.Forms.Button();
            this.butReturnMoney = new System.Windows.Forms.Button();
            this.tableDrinkButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.currentStrength = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.labSugar = new System.Windows.Forms.Label();
            this.barSugar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.currentSugar = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.labStrength = new System.Windows.Forms.Label();
            this.barStrength = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.butPickDrink = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.butBanknote1 = new lab2_CoffeeMachine.ButBanknote();
            this.butBanknote2 = new lab2_CoffeeMachine.ButBanknote();
            this.butBanknote3 = new lab2_CoffeeMachine.ButBanknote();
            this.butBanknote4 = new lab2_CoffeeMachine.ButBanknote();
            this.butMocha = new lab2_CoffeeMachine.ButDrink();
            this.butBlackTeaLemon = new lab2_CoffeeMachine.ButDrink();
            this.butBlackTea = new lab2_CoffeeMachine.ButDrink();
            this.butLatte = new lab2_CoffeeMachine.ButDrink();
            this.butHotChocolate = new lab2_CoffeeMachine.ButDrink();
            this.butCappuccino = new lab2_CoffeeMachine.ButDrink();
            this.butAmericano = new lab2_CoffeeMachine.ButDrink();
            this.butEspresso = new lab2_CoffeeMachine.ButDrink();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableDrinkButtons.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barSugar)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barStrength)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableDrinkButtons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel12, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(400, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 225);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.72492F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.27508F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel3.Controls.Add(this.currentBalance, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(400, 112);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // currentBalance
            // 
            this.currentBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.currentBalance.AutoSize = true;
            this.currentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentBalance.Location = new System.Drawing.Point(309, 47);
            this.currentBalance.Margin = new System.Windows.Forms.Padding(0);
            this.currentBalance.Name = "currentBalance";
            this.tableLayoutPanel3.SetRowSpan(this.currentBalance, 2);
            this.currentBalance.Size = new System.Drawing.Size(91, 17);
            this.currentBalance.TabIndex = 1;
            this.currentBalance.Text = "0р";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(218, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.tableLayoutPanel3.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ваш баланс:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.butBanknote1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.butBanknote2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.butBanknote3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.butBanknote4, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel3.SetRowSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 112);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.butCancelingOperation, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.butReturnMoney, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 112);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(400, 113);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // butCancelingOperation
            // 
            this.butCancelingOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butCancelingOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCancelingOperation.Location = new System.Drawing.Point(200, 0);
            this.butCancelingOperation.Margin = new System.Windows.Forms.Padding(0);
            this.butCancelingOperation.Name = "butCancelingOperation";
            this.butCancelingOperation.Size = new System.Drawing.Size(200, 113);
            this.butCancelingOperation.TabIndex = 1;
            this.butCancelingOperation.Text = "Отмена операции";
            this.butCancelingOperation.UseVisualStyleBackColor = true;
            this.butCancelingOperation.Click += new System.EventHandler(this.butCancelingOperation_Click);
            // 
            // butReturnMoney
            // 
            this.butReturnMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butReturnMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butReturnMoney.Location = new System.Drawing.Point(0, 0);
            this.butReturnMoney.Margin = new System.Windows.Forms.Padding(0);
            this.butReturnMoney.Name = "butReturnMoney";
            this.butReturnMoney.Size = new System.Drawing.Size(200, 113);
            this.butReturnMoney.TabIndex = 0;
            this.butReturnMoney.Text = "Сдача";
            this.butReturnMoney.UseVisualStyleBackColor = true;
            this.butReturnMoney.Click += new System.EventHandler(this.butReturnMoney_Click);
            // 
            // tableDrinkButtons
            // 
            this.tableDrinkButtons.ColumnCount = 4;
            this.tableDrinkButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableDrinkButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableDrinkButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableDrinkButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableDrinkButtons.Controls.Add(this.butMocha, 3, 1);
            this.tableDrinkButtons.Controls.Add(this.butBlackTeaLemon, 2, 1);
            this.tableDrinkButtons.Controls.Add(this.butBlackTea, 1, 1);
            this.tableDrinkButtons.Controls.Add(this.butLatte, 0, 1);
            this.tableDrinkButtons.Controls.Add(this.butHotChocolate, 3, 0);
            this.tableDrinkButtons.Controls.Add(this.butCappuccino, 2, 0);
            this.tableDrinkButtons.Controls.Add(this.butAmericano, 1, 0);
            this.tableDrinkButtons.Controls.Add(this.butEspresso, 0, 0);
            this.tableDrinkButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDrinkButtons.Location = new System.Drawing.Point(0, 0);
            this.tableDrinkButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tableDrinkButtons.Name = "tableDrinkButtons";
            this.tableDrinkButtons.RowCount = 2;
            this.tableDrinkButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDrinkButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDrinkButtons.Size = new System.Drawing.Size(400, 225);
            this.tableDrinkButtons.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel11, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 225);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(400, 225);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.currentStrength, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(200, 112);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(200, 113);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(35, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Текущая крепость";
            // 
            // currentStrength
            // 
            this.currentStrength.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentStrength.AutoSize = true;
            this.currentStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentStrength.Location = new System.Drawing.Point(92, 56);
            this.currentStrength.Margin = new System.Windows.Forms.Padding(0);
            this.currentStrength.Name = "currentStrength";
            this.currentStrength.Size = new System.Drawing.Size(16, 17);
            this.currentStrength.TabIndex = 1;
            this.currentStrength.Text = "1";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.labSugar, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.barSugar, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 112);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // labSugar
            // 
            this.labSugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labSugar.AutoSize = true;
            this.labSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSugar.Location = new System.Drawing.Point(76, 19);
            this.labSugar.Margin = new System.Windows.Forms.Padding(0);
            this.labSugar.Name = "labSugar";
            this.labSugar.Size = new System.Drawing.Size(47, 17);
            this.labSugar.TabIndex = 0;
            this.labSugar.Text = "Сахар";
            // 
            // barSugar
            // 
            this.barSugar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barSugar.LargeChange = 1;
            this.barSugar.Location = new System.Drawing.Point(0, 56);
            this.barSugar.Margin = new System.Windows.Forms.Padding(0);
            this.barSugar.Maximum = 5;
            this.barSugar.Name = "barSugar";
            this.barSugar.Size = new System.Drawing.Size(200, 56);
            this.barSugar.TabIndex = 1;
            this.barSugar.Scroll += new System.EventHandler(this.barSugar_Scroll);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.currentSugar, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(200, 112);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Количество";
            // 
            // currentSugar
            // 
            this.currentSugar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentSugar.AutoSize = true;
            this.currentSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentSugar.Location = new System.Drawing.Point(92, 56);
            this.currentSugar.Margin = new System.Windows.Forms.Padding(0);
            this.currentSugar.Name = "currentSugar";
            this.currentSugar.Size = new System.Drawing.Size(16, 17);
            this.currentSugar.TabIndex = 1;
            this.currentSugar.Text = "0";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.labStrength, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.barStrength, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 112);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(200, 113);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // labStrength
            // 
            this.labStrength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labStrength.AutoSize = true;
            this.labStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labStrength.Location = new System.Drawing.Point(65, 19);
            this.labStrength.Margin = new System.Windows.Forms.Padding(0);
            this.labStrength.Name = "labStrength";
            this.labStrength.Size = new System.Drawing.Size(70, 17);
            this.labStrength.TabIndex = 0;
            this.labStrength.Text = "Крепость";
            // 
            // barStrength
            // 
            this.barStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barStrength.LargeChange = 1;
            this.barStrength.Location = new System.Drawing.Point(0, 56);
            this.barStrength.Margin = new System.Windows.Forms.Padding(0);
            this.barStrength.Maximum = 5;
            this.barStrength.Minimum = 1;
            this.barStrength.Name = "barStrength";
            this.barStrength.Size = new System.Drawing.Size(200, 57);
            this.barStrength.TabIndex = 1;
            this.barStrength.Value = 1;
            this.barStrength.Scroll += new System.EventHandler(this.barStrength_Scroll);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.butPickDrink, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(400, 225);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(400, 225);
            this.tableLayoutPanel12.TabIndex = 3;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.progressBar1, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(400, 112);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(79, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Идикатор процесса приготовления";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(1, 57);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(398, 54);
            this.progressBar1.TabIndex = 1;
            // 
            // butPickDrink
            // 
            this.butPickDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butPickDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPickDrink.Location = new System.Drawing.Point(0, 112);
            this.butPickDrink.Margin = new System.Windows.Forms.Padding(0);
            this.butPickDrink.Name = "butPickDrink";
            this.butPickDrink.Size = new System.Drawing.Size(400, 113);
            this.butPickDrink.TabIndex = 1;
            this.butPickDrink.Text = "Забрать напиток";
            this.butPickDrink.UseVisualStyleBackColor = true;
            this.butPickDrink.Click += new System.EventHandler(this.butPickDrink_Click);
            // 
            // butBanknote1
            // 
            this.butBanknote1.Denomination = 10;
            this.butBanknote1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBanknote1.Location = new System.Drawing.Point(0, 0);
            this.butBanknote1.Margin = new System.Windows.Forms.Padding(0);
            this.butBanknote1.Name = "butBanknote1";
            this.butBanknote1.Size = new System.Drawing.Size(100, 56);
            this.butBanknote1.TabIndex = 0;
            this.butBanknote1.TextBut = "10р";
            // 
            // butBanknote2
            // 
            this.butBanknote2.Denomination = 50;
            this.butBanknote2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBanknote2.Location = new System.Drawing.Point(100, 0);
            this.butBanknote2.Margin = new System.Windows.Forms.Padding(0);
            this.butBanknote2.Name = "butBanknote2";
            this.butBanknote2.Size = new System.Drawing.Size(100, 56);
            this.butBanknote2.TabIndex = 1;
            this.butBanknote2.TextBut = "50р";
            // 
            // butBanknote3
            // 
            this.butBanknote3.Denomination = 100;
            this.butBanknote3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBanknote3.Location = new System.Drawing.Point(0, 56);
            this.butBanknote3.Margin = new System.Windows.Forms.Padding(0);
            this.butBanknote3.Name = "butBanknote3";
            this.butBanknote3.Size = new System.Drawing.Size(100, 56);
            this.butBanknote3.TabIndex = 2;
            this.butBanknote3.TextBut = "100р";
            // 
            // butBanknote4
            // 
            this.butBanknote4.Denomination = 500;
            this.butBanknote4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBanknote4.Location = new System.Drawing.Point(100, 56);
            this.butBanknote4.Margin = new System.Windows.Forms.Padding(0);
            this.butBanknote4.Name = "butBanknote4";
            this.butBanknote4.Size = new System.Drawing.Size(100, 56);
            this.butBanknote4.TabIndex = 3;
            this.butBanknote4.TextBut = "500р";
            // 
            // butMocha
            // 
            this.butMocha.CookingTime = 2000;
            this.butMocha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butMocha.DrinkName = "Мокко\n40р";
            this.butMocha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMocha.Location = new System.Drawing.Point(300, 112);
            this.butMocha.Margin = new System.Windows.Forms.Padding(0);
            this.butMocha.Name = "butMocha";
            this.butMocha.Price = 40;
            this.butMocha.Size = new System.Drawing.Size(100, 113);
            this.butMocha.Strength = 0;
            this.butMocha.Sugar = 0;
            this.butMocha.TabIndex = 7;
            // 
            // butBlackTeaLemon
            // 
            this.butBlackTeaLemon.CookingTime = 10000;
            this.butBlackTeaLemon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBlackTeaLemon.DrinkName = "Чай черный с лимоном\n15р";
            this.butBlackTeaLemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBlackTeaLemon.Location = new System.Drawing.Point(200, 112);
            this.butBlackTeaLemon.Margin = new System.Windows.Forms.Padding(0);
            this.butBlackTeaLemon.Name = "butBlackTeaLemon";
            this.butBlackTeaLemon.Price = 15;
            this.butBlackTeaLemon.Size = new System.Drawing.Size(100, 113);
            this.butBlackTeaLemon.Strength = 0;
            this.butBlackTeaLemon.Sugar = 0;
            this.butBlackTeaLemon.TabIndex = 6;
            // 
            // butBlackTea
            // 
            this.butBlackTea.CookingTime = 10000;
            this.butBlackTea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBlackTea.DrinkName = "Чай черный\n15р";
            this.butBlackTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBlackTea.Location = new System.Drawing.Point(100, 112);
            this.butBlackTea.Margin = new System.Windows.Forms.Padding(0);
            this.butBlackTea.Name = "butBlackTea";
            this.butBlackTea.Price = 15;
            this.butBlackTea.Size = new System.Drawing.Size(100, 113);
            this.butBlackTea.Strength = 0;
            this.butBlackTea.Sugar = 0;
            this.butBlackTea.TabIndex = 5;
            // 
            // butLatte
            // 
            this.butLatte.CookingTime = 15000;
            this.butLatte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butLatte.DrinkName = "Латте\n40р";
            this.butLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butLatte.Location = new System.Drawing.Point(0, 112);
            this.butLatte.Margin = new System.Windows.Forms.Padding(0);
            this.butLatte.Name = "butLatte";
            this.butLatte.Price = 40;
            this.butLatte.Size = new System.Drawing.Size(100, 113);
            this.butLatte.Strength = 0;
            this.butLatte.Sugar = 0;
            this.butLatte.TabIndex = 4;
            // 
            // butHotChocolate
            // 
            this.butHotChocolate.CookingTime = 10000;
            this.butHotChocolate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butHotChocolate.DrinkName = "Горячий шоколад\n20р";
            this.butHotChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butHotChocolate.Location = new System.Drawing.Point(300, 0);
            this.butHotChocolate.Margin = new System.Windows.Forms.Padding(0);
            this.butHotChocolate.Name = "butHotChocolate";
            this.butHotChocolate.Price = 20;
            this.butHotChocolate.Size = new System.Drawing.Size(100, 112);
            this.butHotChocolate.Strength = 0;
            this.butHotChocolate.Sugar = 0;
            this.butHotChocolate.TabIndex = 3;
            // 
            // butCappuccino
            // 
            this.butCappuccino.CookingTime = 15000;
            this.butCappuccino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butCappuccino.DrinkName = "Капучино\n40р";
            this.butCappuccino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCappuccino.Location = new System.Drawing.Point(200, 0);
            this.butCappuccino.Margin = new System.Windows.Forms.Padding(0);
            this.butCappuccino.Name = "butCappuccino";
            this.butCappuccino.Price = 40;
            this.butCappuccino.Size = new System.Drawing.Size(100, 112);
            this.butCappuccino.Strength = 0;
            this.butCappuccino.Sugar = 0;
            this.butCappuccino.TabIndex = 2;
            // 
            // butAmericano
            // 
            this.butAmericano.CookingTime = 12000;
            this.butAmericano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butAmericano.DrinkName = "Американо\n30р";
            this.butAmericano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAmericano.Location = new System.Drawing.Point(100, 0);
            this.butAmericano.Margin = new System.Windows.Forms.Padding(0);
            this.butAmericano.Name = "butAmericano";
            this.butAmericano.Price = 30;
            this.butAmericano.Size = new System.Drawing.Size(100, 112);
            this.butAmericano.Strength = 0;
            this.butAmericano.Sugar = 0;
            this.butAmericano.TabIndex = 1;
            // 
            // butEspresso
            // 
            this.butEspresso.CookingTime = 10000;
            this.butEspresso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butEspresso.DrinkName = "Эспрессо\n20р";
            this.butEspresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEspresso.Location = new System.Drawing.Point(0, 0);
            this.butEspresso.Margin = new System.Windows.Forms.Padding(0);
            this.butEspresso.Name = "butEspresso";
            this.butEspresso.Price = 20;
            this.butEspresso.Size = new System.Drawing.Size(100, 112);
            this.butEspresso.Strength = 0;
            this.butEspresso.Sugar = 0;
            this.butEspresso.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableDrinkButtons.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barSugar)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barStrength)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label currentBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label labSugar;
        private System.Windows.Forms.TrackBar barSugar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentSugar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button butCancelingOperation;
        private System.Windows.Forms.Button butReturnMoney;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentStrength;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label labStrength;
        private System.Windows.Forms.TrackBar barStrength;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button butPickDrink;
        private ButDrink butBlackTeaLemon;
        private ButDrink butBlackTea;
        private ButDrink butLatte;
        private ButDrink butHotChocolate;
        private ButDrink butCappuccino;
        private ButDrink butAmericano;
        private ButDrink butEspresso;
        private ButBanknote butBanknote1;
        private ButBanknote butBanknote2;
        private ButBanknote butBanknote3;
        private ButBanknote butBanknote4;
        private System.Windows.Forms.TableLayoutPanel tableDrinkButtons;
        private ButDrink butMocha;
        private System.Windows.Forms.Timer timer1;
    }
}

