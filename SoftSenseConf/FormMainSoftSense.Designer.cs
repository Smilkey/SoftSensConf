
namespace SoftSenseConf
{
    partial class FormMainSoftSense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label modelNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label measurementUnitLabel;
            System.Windows.Forms.Label intervalLabel;
            System.Windows.Forms.Label areaIDLabel2;
            System.Windows.Forms.Label companyIDLabel2;
            System.Windows.Forms.Label modelNumberLabel3;
            System.Windows.Forms.Label dAU_IDLabel2;
            System.Windows.Forms.Label descriptionLabel3;
            System.Windows.Forms.Label measurementUnitLabel1;
            System.Windows.Forms.Label intervalLabel1;
            System.Windows.Forms.Label alarmHighLabel;
            System.Windows.Forms.Label alarmLowLabel;
            System.Windows.Forms.Label upperRangeValuesLabel;
            System.Windows.Forms.Label loweRangeValuesLabel;
            System.Windows.Forms.Label tagNameLabel;
            System.Windows.Forms.Label areaIDLabel;
            System.Windows.Forms.Label companyIDLabel;
            System.Windows.Forms.Label modelNumberLabel1;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label stop_bitLabel;
            System.Windows.Forms.Label parityLabel;
            System.Windows.Forms.Label data_bitsLabel;
            System.Windows.Forms.Label baud_rateLabel;
            System.Windows.Forms.Label deviceNameLabel;
            System.Windows.Forms.Label dAU_IDLabel;
            System.Windows.Forms.Label areaIDLabel1;
            System.Windows.Forms.Label companyIDLabel1;
            System.Windows.Forms.Label modelNumberLabel2;
            System.Windows.Forms.Label computer_IDLabel;
            System.Windows.Forms.Label descriptionLabel2;
            System.Windows.Forms.Label stop_bitLabel1;
            System.Windows.Forms.Label parityLabel1;
            System.Windows.Forms.Label data_bitsLabel1;
            System.Windows.Forms.Label baud_rateLabel1;
            System.Windows.Forms.Label deviceNameLabel1;
            System.Windows.Forms.Label dAU_IDLabel1;
            this.serialPort_ComPorts = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog_saveConfigurations = new System.Windows.Forms.SaveFileDialog();
            this.timer_configurations = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_instrumentConfig = new System.Windows.Forms.OpenFileDialog();
            this.timer_write = new System.Windows.Forms.Timer(this.components);
            this.timer_rawValuesLive = new System.Windows.Forms.Timer(this.components);
            this.timer_rawValuesLive2 = new System.Windows.Forms.Timer(this.components);
            this.timer_scaledLive1 = new System.Windows.Forms.Timer(this.components);
            this.timer_scaledLive2 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog_currentValues = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog_chartRaw = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog_chartScaled = new System.Windows.Forms.SaveFileDialog();
            this.iNSTRUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softSensConfDataSet = new SoftSenseConf.SoftSensConfDataSet();
            this.iNSTRUMENT1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDC1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPANYBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tYPEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dAU1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tYPEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPANYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dAUTableAdapter = new SoftSenseConf.SoftSensConfDataSetTableAdapters.DAUTableAdapter();
            this.tableAdapterManager = new SoftSenseConf.SoftSensConfDataSetTableAdapters.TableAdapterManager();
            this.areaTableAdapter = new SoftSenseConf.SoftSensConfDataSetTableAdapters.AreaTableAdapter();
            this.cOMPANYTableAdapter = new SoftSenseConf.SoftSensConfDataSetTableAdapters.COMPANYTableAdapter();
            this.dAU1TableAdapter = new SoftSenseConf.SoftSensConfDataSetTableAdapters.DAU1TableAdapter();
            this.tYPETableAdapter = new SoftSenseConf.SoftSensConfDataSetTableAdapters.TYPETableAdapter();
            this.rDCTableAdapter = new SoftSenseConf.SoftSensConfDataSetTableAdapters.RDCTableAdapter();
            this.iNSTRUMENT1TableAdapter = new SoftSenseConf.SoftSensConfDataSetTableAdapters.INSTRUMENT1TableAdapter();
            this.iNSTRUMENTTableAdapter = new SoftSenseConf.SoftSensConfDataSetTableAdapters.INSTRUMENTTableAdapter();
            this.rDC1TableAdapter = new SoftSenseConf.SoftSensConfDataSetTableAdapters.RDC1TableAdapter();
            this.mCUTableAdapter = new SoftSenseConf.SoftSensConfDataSetTableAdapters.MCUTableAdapter();
            this.tabPage_currentValues = new System.Windows.Forms.TabPage();
            this.toolStrip_currentValues = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_currentValues = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3_disconnected = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3_connected = new System.Windows.Forms.ToolStripLabel();
            this.groupBox_rawValues = new System.Windows.Forms.GroupBox();
            this.chart_rawValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_scaledLive = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox_liveData = new System.Windows.Forms.GroupBox();
            this.listBox_liveDataRaw = new System.Windows.Forms.ListBox();
            this.button_saveCurrentValues = new System.Windows.Forms.Button();
            this.button_resetCurrentValues = new System.Windows.Forms.Button();
            this.checkBox_raw = new System.Windows.Forms.CheckBox();
            this.button_startLiveValues = new System.Windows.Forms.Button();
            this.button_saveChart = new System.Windows.Forms.Button();
            this.checkBox_scaled = new System.Windows.Forms.CheckBox();
            this.button_status2 = new System.Windows.Forms.Button();
            this.button_stopLive = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.groupBox_scaledValues = new System.Windows.Forms.GroupBox();
            this.listBox_liveDataScaled = new System.Windows.Forms.ListBox();
            this.label_sentToDatabase = new System.Windows.Forms.Label();
            this.labelloggingInterval = new System.Windows.Forms.Label();
            this.labelStandardInterval = new System.Windows.Forms.Label();
            this.tabPage_instrumentConfig = new System.Windows.Forms.TabPage();
            this.toolStrip_instrumentConf = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_instrumentConfig = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2_disconnected = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2_connected = new System.Windows.Forms.ToolStripLabel();
            this.groupBox_values = new System.Windows.Forms.GroupBox();
            this.label_alarmLow = new System.Windows.Forms.Label();
            this.label_URV = new System.Windows.Forms.Label();
            this.label_alarmHigh = new System.Windows.Forms.Label();
            this.button_read = new System.Windows.Forms.Button();
            this.label_LRV = new System.Windows.Forms.Label();
            this.textBox_alarmHigh = new System.Windows.Forms.TextBox();
            this.textBox_lowerRangeValue = new System.Windows.Forms.TextBox();
            this.textBox_upperRangeValue = new System.Windows.Forms.TextBox();
            this.button_write = new System.Windows.Forms.Button();
            this.button_status = new System.Windows.Forms.Button();
            this.textBox_alarmLow = new System.Windows.Forms.TextBox();
            this.textBox_tagName = new System.Windows.Forms.TextBox();
            this.label_tagName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_DAU_ID = new System.Windows.Forms.ComboBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.button_DatabaseConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.gbFilterInstrument = new System.Windows.Forms.GroupBox();
            this.cbFindInstrument = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.areaIDTextBox = new System.Windows.Forms.TextBox();
            this.companyIDTextBox = new System.Windows.Forms.TextBox();
            this.modelNumberTextBox = new System.Windows.Forms.TextBox();
            this.dAU_IDTextBox2 = new System.Windows.Forms.TextBox();
            this.descriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.measurementUnitTextBox = new System.Windows.Forms.TextBox();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.alarmHighTextBox = new System.Windows.Forms.TextBox();
            this.alarmLowTextBox = new System.Windows.Forms.TextBox();
            this.upperRangeValuesTextBox = new System.Windows.Forms.TextBox();
            this.loweRangeValuesTextBox = new System.Windows.Forms.TextBox();
            this.tagNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox_configData = new System.Windows.Forms.GroupBox();
            this.button_scaled = new System.Windows.Forms.Button();
            this.button_raw = new System.Windows.Forms.Button();
            this.button_saveConfigurations = new System.Windows.Forms.Button();
            this.button_loadValue = new System.Windows.Forms.Button();
            this.textBox_showConfigurations = new System.Windows.Forms.TextBox();
            this.tabPage_DAU = new System.Windows.Forms.TabPage();
            this.toolStrip_InputOutput = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4_disconnected = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4_connected = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelDAU = new System.Windows.Forms.ToolStripLabel();
            this.groupBox_DAUFiltering = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.stop_bitTextBox = new System.Windows.Forms.TextBox();
            this.parityTextBox = new System.Windows.Forms.TextBox();
            this.data_bitsTextBox = new System.Windows.Forms.TextBox();
            this.baud_rateTextBox = new System.Windows.Forms.TextBox();
            this.deviceNameTextBox = new System.Windows.Forms.TextBox();
            this.dAU_IDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFindDeviceDAU = new System.Windows.Forms.ComboBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.computer_IDTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdateDAU = new System.Windows.Forms.Button();
            this.btnClearDAU = new System.Windows.Forms.Button();
            this.groupBoxDAURegUpd = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.stop_bitTextBox1 = new System.Windows.Forms.TextBox();
            this.parityTextBox1 = new System.Windows.Forms.TextBox();
            this.data_bitsTextBox1 = new System.Windows.Forms.TextBox();
            this.baud_rateTextBox1 = new System.Windows.Forms.TextBox();
            this.deviceNameTextBox1 = new System.Windows.Forms.TextBox();
            this.dAU_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.cbRDCdau = new System.Windows.Forms.ComboBox();
            this.cbModelDAU = new System.Windows.Forms.ComboBox();
            this.cbCompanyDAU = new System.Windows.Forms.ComboBox();
            this.cbLocationDAU = new System.Windows.Forms.ComboBox();
            this.tabPage_serialPortConfig = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_com = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_connected = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_disconnected = new System.Windows.Forms.ToolStripLabel();
            this.groupBox_selectPortAndBaud = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelComPorts = new System.Windows.Forms.Label();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.button_about = new System.Windows.Forms.Button();
            this.tabControl_DAU = new System.Windows.Forms.TabControl();
            locationLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            modelNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            measurementUnitLabel = new System.Windows.Forms.Label();
            intervalLabel = new System.Windows.Forms.Label();
            areaIDLabel2 = new System.Windows.Forms.Label();
            companyIDLabel2 = new System.Windows.Forms.Label();
            modelNumberLabel3 = new System.Windows.Forms.Label();
            dAU_IDLabel2 = new System.Windows.Forms.Label();
            descriptionLabel3 = new System.Windows.Forms.Label();
            measurementUnitLabel1 = new System.Windows.Forms.Label();
            intervalLabel1 = new System.Windows.Forms.Label();
            alarmHighLabel = new System.Windows.Forms.Label();
            alarmLowLabel = new System.Windows.Forms.Label();
            upperRangeValuesLabel = new System.Windows.Forms.Label();
            loweRangeValuesLabel = new System.Windows.Forms.Label();
            tagNameLabel = new System.Windows.Forms.Label();
            areaIDLabel = new System.Windows.Forms.Label();
            companyIDLabel = new System.Windows.Forms.Label();
            modelNumberLabel1 = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            stop_bitLabel = new System.Windows.Forms.Label();
            parityLabel = new System.Windows.Forms.Label();
            data_bitsLabel = new System.Windows.Forms.Label();
            baud_rateLabel = new System.Windows.Forms.Label();
            deviceNameLabel = new System.Windows.Forms.Label();
            dAU_IDLabel = new System.Windows.Forms.Label();
            areaIDLabel1 = new System.Windows.Forms.Label();
            companyIDLabel1 = new System.Windows.Forms.Label();
            modelNumberLabel2 = new System.Windows.Forms.Label();
            computer_IDLabel = new System.Windows.Forms.Label();
            descriptionLabel2 = new System.Windows.Forms.Label();
            stop_bitLabel1 = new System.Windows.Forms.Label();
            parityLabel1 = new System.Windows.Forms.Label();
            data_bitsLabel1 = new System.Windows.Forms.Label();
            baud_rateLabel1 = new System.Windows.Forms.Label();
            deviceNameLabel1 = new System.Windows.Forms.Label();
            dAU_IDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensConfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENT1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDC1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAU1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource1)).BeginInit();
            this.tabPage_currentValues.SuspendLayout();
            this.toolStrip_currentValues.SuspendLayout();
            this.groupBox_rawValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_rawValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_scaledLive)).BeginInit();
            this.groupBox_liveData.SuspendLayout();
            this.groupBox_scaledValues.SuspendLayout();
            this.tabPage_instrumentConfig.SuspendLayout();
            this.toolStrip_instrumentConf.SuspendLayout();
            this.groupBox_values.SuspendLayout();
            this.gbFilterInstrument.SuspendLayout();
            this.groupBox_configData.SuspendLayout();
            this.tabPage_DAU.SuspendLayout();
            this.toolStrip_InputOutput.SuspendLayout();
            this.groupBox_DAUFiltering.SuspendLayout();
            this.groupBoxDAURegUpd.SuspendLayout();
            this.tabPage_serialPortConfig.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox_selectPortAndBaud.SuspendLayout();
            this.tabControl_DAU.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog_saveConfigurations
            // 
            this.saveFileDialog_saveConfigurations.DefaultExt = "ssc";
            // 
            // timer_configurations
            // 
            this.timer_configurations.Tick += new System.EventHandler(this.timer_configurations_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            // 
            // openFileDialog_instrumentConfig
            // 
            this.openFileDialog_instrumentConfig.DefaultExt = "ssc";
            this.openFileDialog_instrumentConfig.FileName = "openFileDialog1";
            // 
            // timer_write
            // 
            this.timer_write.Tick += new System.EventHandler(this.timer_write_Tick);
            // 
            // timer_rawValuesLive
            // 
            this.timer_rawValuesLive.Interval = 1000;
            this.timer_rawValuesLive.Tick += new System.EventHandler(this.timer_rawValuesLive_Tick);
            // 
            // timer_rawValuesLive2
            // 
            this.timer_rawValuesLive2.Interval = 1000;
            this.timer_rawValuesLive2.Tick += new System.EventHandler(this.timer_rawValuesLive2_Tick);
            // 
            // timer_scaledLive1
            // 
            this.timer_scaledLive1.Interval = 1000;
            this.timer_scaledLive1.Tick += new System.EventHandler(this.timer_scaledLive1_Tick);
            // 
            // timer_scaledLive2
            // 
            this.timer_scaledLive2.Interval = 1000;
            this.timer_scaledLive2.Tick += new System.EventHandler(this.timer_scaledLive2_Tick);
            // 
            // saveFileDialog_currentValues
            // 
            this.saveFileDialog_currentValues.DefaultExt = "csv";
            // 
            // saveFileDialog_chartRaw
            // 
            this.saveFileDialog_chartRaw.DefaultExt = "png";
            // 
            // saveFileDialog_chartScaled
            // 
            this.saveFileDialog_chartScaled.DefaultExt = "png";
            // 
            // iNSTRUMENTBindingSource
            // 
            this.iNSTRUMENTBindingSource.DataMember = "INSTRUMENT";
            this.iNSTRUMENTBindingSource.DataSource = this.softSensConfDataSet;
            // 
            // softSensConfDataSet
            // 
            this.softSensConfDataSet.DataSetName = "SoftSensConfDataSet";
            this.softSensConfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNSTRUMENT1BindingSource
            // 
            this.iNSTRUMENT1BindingSource.DataMember = "INSTRUMENT1";
            this.iNSTRUMENT1BindingSource.DataSource = this.softSensConfDataSet;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.softSensConfDataSet;
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = this.softSensConfDataSet;
            // 
            // tYPEBindingSource
            // 
            this.tYPEBindingSource.DataMember = "TYPE";
            this.tYPEBindingSource.DataSource = this.softSensConfDataSet;
            // 
            // dAUBindingSource
            // 
            this.dAUBindingSource.DataMember = "DAU";
            this.dAUBindingSource.DataSource = this.softSensConfDataSet;
            // 
            // mCUBindingSource
            // 
            this.mCUBindingSource.DataMember = "MCU";
            this.mCUBindingSource.DataSource = this.softSensConfDataSet;
            // 
            // rDCBindingSource
            // 
            this.rDCBindingSource.DataMember = "RDC";
            this.rDCBindingSource.DataSource = this.softSensConfDataSet;
            // 
            // rDC1BindingSource
            // 
            this.rDC1BindingSource.DataMember = "RDC1";
            this.rDC1BindingSource.DataSource = this.softSensConfDataSet;
            // 
            // areaBindingSource2
            // 
            this.areaBindingSource2.DataMember = "Area";
            this.areaBindingSource2.DataSource = this.softSensConfDataSet;
            // 
            // cOMPANYBindingSource2
            // 
            this.cOMPANYBindingSource2.DataMember = "COMPANY";
            this.cOMPANYBindingSource2.DataSource = this.softSensConfDataSet;
            // 
            // tYPEBindingSource2
            // 
            this.tYPEBindingSource2.DataMember = "TYPE";
            this.tYPEBindingSource2.DataSource = this.softSensConfDataSet;
            // 
            // dAU1BindingSource
            // 
            this.dAU1BindingSource.DataMember = "DAU1";
            this.dAU1BindingSource.DataSource = this.softSensConfDataSet;
            // 
            // areaBindingSource1
            // 
            this.areaBindingSource1.DataMember = "Area";
            this.areaBindingSource1.DataSource = this.softSensConfDataSet;
            // 
            // tYPEBindingSource1
            // 
            this.tYPEBindingSource1.DataMember = "TYPE";
            this.tYPEBindingSource1.DataSource = this.softSensConfDataSet;
            // 
            // cOMPANYBindingSource1
            // 
            this.cOMPANYBindingSource1.DataMember = "COMPANY";
            this.cOMPANYBindingSource1.DataSource = this.softSensConfDataSet;
            // 
            // dAUTableAdapter
            // 
            this.dAUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AITableAdapter = null;
            this.tableAdapterManager.AOTableAdapter = null;
            this.tableAdapterManager.AreaTableAdapter = this.areaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COMPANYTableAdapter = this.cOMPANYTableAdapter;
            this.tableAdapterManager.DAU1TableAdapter = this.dAU1TableAdapter;
            this.tableAdapterManager.DAUTableAdapter = this.dAUTableAdapter;
            this.tableAdapterManager.DITableAdapter = null;
            this.tableAdapterManager.DOTableAdapter = null;
            this.tableAdapterManager.INSTRUMENT1TableAdapter = null;
            this.tableAdapterManager.INSTRUMENTTableAdapter = null;
            this.tableAdapterManager.MCUTableAdapter = null;
            this.tableAdapterManager.RDC1TableAdapter = null;
            this.tableAdapterManager.RDCTableAdapter = null;
            this.tableAdapterManager.TYPETableAdapter = this.tYPETableAdapter;
            this.tableAdapterManager.UpdateOrder = SoftSenseConf.SoftSensConfDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // cOMPANYTableAdapter
            // 
            this.cOMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // dAU1TableAdapter
            // 
            this.dAU1TableAdapter.ClearBeforeFill = true;
            // 
            // tYPETableAdapter
            // 
            this.tYPETableAdapter.ClearBeforeFill = true;
            // 
            // rDCTableAdapter
            // 
            this.rDCTableAdapter.ClearBeforeFill = true;
            // 
            // iNSTRUMENT1TableAdapter
            // 
            this.iNSTRUMENT1TableAdapter.ClearBeforeFill = true;
            // 
            // iNSTRUMENTTableAdapter
            // 
            this.iNSTRUMENTTableAdapter.ClearBeforeFill = true;
            // 
            // rDC1TableAdapter
            // 
            this.rDC1TableAdapter.ClearBeforeFill = true;
            // 
            // mCUTableAdapter
            // 
            this.mCUTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage_currentValues
            // 
            this.tabPage_currentValues.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_currentValues.Controls.Add(this.labelStandardInterval);
            this.tabPage_currentValues.Controls.Add(this.labelloggingInterval);
            this.tabPage_currentValues.Controls.Add(this.label_sentToDatabase);
            this.tabPage_currentValues.Controls.Add(this.groupBox_scaledValues);
            this.tabPage_currentValues.Controls.Add(this.label_status);
            this.tabPage_currentValues.Controls.Add(this.button_stopLive);
            this.tabPage_currentValues.Controls.Add(this.button_status2);
            this.tabPage_currentValues.Controls.Add(this.checkBox_scaled);
            this.tabPage_currentValues.Controls.Add(this.button_saveChart);
            this.tabPage_currentValues.Controls.Add(this.button_startLiveValues);
            this.tabPage_currentValues.Controls.Add(this.checkBox_raw);
            this.tabPage_currentValues.Controls.Add(this.button_resetCurrentValues);
            this.tabPage_currentValues.Controls.Add(this.button_saveCurrentValues);
            this.tabPage_currentValues.Controls.Add(this.groupBox_liveData);
            this.tabPage_currentValues.Controls.Add(this.groupBox_rawValues);
            this.tabPage_currentValues.Controls.Add(this.toolStrip_currentValues);
            this.tabPage_currentValues.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage_currentValues.Location = new System.Drawing.Point(4, 22);
            this.tabPage_currentValues.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage_currentValues.Name = "tabPage_currentValues";
            this.tabPage_currentValues.Size = new System.Drawing.Size(800, 474);
            this.tabPage_currentValues.TabIndex = 2;
            this.tabPage_currentValues.Text = "4. Current Values";
            // 
            // toolStrip_currentValues
            // 
            this.toolStrip_currentValues.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_currentValues.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip_currentValues.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_currentValues,
            this.toolStripLabel3_disconnected,
            this.toolStripLabel3_connected});
            this.toolStrip_currentValues.Location = new System.Drawing.Point(0, 449);
            this.toolStrip_currentValues.Name = "toolStrip_currentValues";
            this.toolStrip_currentValues.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip_currentValues.Size = new System.Drawing.Size(800, 25);
            this.toolStrip_currentValues.TabIndex = 2;
            this.toolStrip_currentValues.Text = "toolStrip3";
            // 
            // toolStripLabel_currentValues
            // 
            this.toolStripLabel_currentValues.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripLabel_currentValues.Name = "toolStripLabel_currentValues";
            this.toolStripLabel_currentValues.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel_currentValues.Text = "ToolTip";
            // 
            // toolStripLabel3_disconnected
            // 
            this.toolStripLabel3_disconnected.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3_disconnected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3_disconnected.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel3_disconnected.Name = "toolStripLabel3_disconnected";
            this.toolStripLabel3_disconnected.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel3_disconnected.Text = "Disconnected";
            this.toolStripLabel3_disconnected.Visible = false;
            // 
            // toolStripLabel3_connected
            // 
            this.toolStripLabel3_connected.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3_connected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3_connected.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripLabel3_connected.Name = "toolStripLabel3_connected";
            this.toolStripLabel3_connected.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel3_connected.Text = "Connected";
            this.toolStripLabel3_connected.Visible = false;
            // 
            // groupBox_rawValues
            // 
            this.groupBox_rawValues.Controls.Add(this.chart_scaledLive);
            this.groupBox_rawValues.Controls.Add(this.chart_rawValues);
            this.groupBox_rawValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_rawValues.Location = new System.Drawing.Point(314, 1);
            this.groupBox_rawValues.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox_rawValues.Name = "groupBox_rawValues";
            this.groupBox_rawValues.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox_rawValues.Size = new System.Drawing.Size(454, 354);
            this.groupBox_rawValues.TabIndex = 1;
            this.groupBox_rawValues.TabStop = false;
            this.groupBox_rawValues.Text = "Live Values";
            // 
            // chart_rawValues
            // 
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Title = "Light";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.chart_rawValues.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_rawValues.Legends.Add(legend2);
            this.chart_rawValues.Location = new System.Drawing.Point(8, 22);
            this.chart_rawValues.Margin = new System.Windows.Forms.Padding(1);
            this.chart_rawValues.Name = "chart_rawValues";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Raw Values";
            this.chart_rawValues.Series.Add(series2);
            this.chart_rawValues.Size = new System.Drawing.Size(439, 325);
            this.chart_rawValues.TabIndex = 0;
            this.chart_rawValues.TabStop = false;
            this.chart_rawValues.Text = "Raw values";
            this.chart_rawValues.Visible = false;
            // 
            // chart_scaledLive
            // 
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Light";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart_scaledLive.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_scaledLive.Legends.Add(legend1);
            this.chart_scaledLive.Location = new System.Drawing.Point(8, 22);
            this.chart_scaledLive.Margin = new System.Windows.Forms.Padding(1);
            this.chart_scaledLive.Name = "chart_scaledLive";
            this.chart_scaledLive.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Scaled Values";
            this.chart_scaledLive.Series.Add(series1);
            this.chart_scaledLive.Size = new System.Drawing.Size(439, 325);
            this.chart_scaledLive.TabIndex = 1;
            this.chart_scaledLive.TabStop = false;
            this.chart_scaledLive.Text = "chart1";
            this.chart_scaledLive.Visible = false;
            // 
            // groupBox_liveData
            // 
            this.groupBox_liveData.Controls.Add(this.listBox_liveDataRaw);
            this.groupBox_liveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_liveData.Location = new System.Drawing.Point(43, 73);
            this.groupBox_liveData.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox_liveData.Name = "groupBox_liveData";
            this.groupBox_liveData.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox_liveData.Size = new System.Drawing.Size(96, 175);
            this.groupBox_liveData.TabIndex = 8;
            this.groupBox_liveData.TabStop = false;
            this.groupBox_liveData.Text = "Raw";
            // 
            // listBox_liveDataRaw
            // 
            this.listBox_liveDataRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_liveDataRaw.FormattingEnabled = true;
            this.listBox_liveDataRaw.ItemHeight = 15;
            this.listBox_liveDataRaw.Location = new System.Drawing.Point(6, 16);
            this.listBox_liveDataRaw.Margin = new System.Windows.Forms.Padding(1);
            this.listBox_liveDataRaw.Name = "listBox_liveDataRaw";
            this.listBox_liveDataRaw.Size = new System.Drawing.Size(85, 139);
            this.listBox_liveDataRaw.TabIndex = 5;
            this.listBox_liveDataRaw.TabStop = false;
            // 
            // button_saveCurrentValues
            // 
            this.button_saveCurrentValues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_saveCurrentValues.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_saveCurrentValues.Location = new System.Drawing.Point(70, 339);
            this.button_saveCurrentValues.Margin = new System.Windows.Forms.Padding(1);
            this.button_saveCurrentValues.Name = "button_saveCurrentValues";
            this.button_saveCurrentValues.Size = new System.Drawing.Size(69, 24);
            this.button_saveCurrentValues.TabIndex = 3;
            this.button_saveCurrentValues.Text = "Save Data";
            this.button_saveCurrentValues.UseVisualStyleBackColor = true;
            this.button_saveCurrentValues.Click += new System.EventHandler(this.button_saveCurrentValues_Click);
            this.button_saveCurrentValues.MouseLeave += new System.EventHandler(this.button_saveCurrentValues_MouseLeave);
            this.button_saveCurrentValues.MouseHover += new System.EventHandler(this.button_saveCurrentValues_MouseHover);
            // 
            // button_resetCurrentValues
            // 
            this.button_resetCurrentValues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_resetCurrentValues.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_resetCurrentValues.Location = new System.Drawing.Point(314, 359);
            this.button_resetCurrentValues.Name = "button_resetCurrentValues";
            this.button_resetCurrentValues.Size = new System.Drawing.Size(75, 23);
            this.button_resetCurrentValues.TabIndex = 5;
            this.button_resetCurrentValues.Text = "Reset";
            this.button_resetCurrentValues.UseVisualStyleBackColor = true;
            this.button_resetCurrentValues.Click += new System.EventHandler(this.button_resetCurrentValues_Click);
            this.button_resetCurrentValues.MouseLeave += new System.EventHandler(this.button_resetCurrentValues_MouseLeave);
            this.button_resetCurrentValues.MouseHover += new System.EventHandler(this.button_resetCurrentValues_MouseHover);
            // 
            // checkBox_raw
            // 
            this.checkBox_raw.AutoSize = true;
            this.checkBox_raw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_raw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_raw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_raw.Location = new System.Drawing.Point(50, 251);
            this.checkBox_raw.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_raw.Name = "checkBox_raw";
            this.checkBox_raw.Size = new System.Drawing.Size(91, 19);
            this.checkBox_raw.TabIndex = 6;
            this.checkBox_raw.TabStop = false;
            this.checkBox_raw.Text = "Raw Values";
            this.checkBox_raw.UseVisualStyleBackColor = true;
            // 
            // button_startLiveValues
            // 
            this.button_startLiveValues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_startLiveValues.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_startLiveValues.Location = new System.Drawing.Point(70, 314);
            this.button_startLiveValues.Margin = new System.Windows.Forms.Padding(1);
            this.button_startLiveValues.Name = "button_startLiveValues";
            this.button_startLiveValues.Size = new System.Drawing.Size(69, 25);
            this.button_startLiveValues.TabIndex = 1;
            this.button_startLiveValues.Text = "Start";
            this.button_startLiveValues.UseVisualStyleBackColor = true;
            this.button_startLiveValues.Click += new System.EventHandler(this.button_startLiveValues_Click);
            this.button_startLiveValues.MouseLeave += new System.EventHandler(this.button_startLiveValues_MouseLeave);
            this.button_startLiveValues.MouseHover += new System.EventHandler(this.button_startLiveValues_MouseHover);
            // 
            // button_saveChart
            // 
            this.button_saveChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_saveChart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_saveChart.Location = new System.Drawing.Point(141, 339);
            this.button_saveChart.Margin = new System.Windows.Forms.Padding(1);
            this.button_saveChart.Name = "button_saveChart";
            this.button_saveChart.Size = new System.Drawing.Size(69, 24);
            this.button_saveChart.TabIndex = 4;
            this.button_saveChart.Text = "Save Chart";
            this.button_saveChart.UseVisualStyleBackColor = true;
            this.button_saveChart.Click += new System.EventHandler(this.button_saveChart_Click);
            this.button_saveChart.MouseLeave += new System.EventHandler(this.button_saveChart_MouseLeave);
            this.button_saveChart.MouseHover += new System.EventHandler(this.button_saveChart_MouseHover);
            // 
            // checkBox_scaled
            // 
            this.checkBox_scaled.AutoSize = true;
            this.checkBox_scaled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_scaled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_scaled.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_scaled.Location = new System.Drawing.Point(145, 251);
            this.checkBox_scaled.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_scaled.Name = "checkBox_scaled";
            this.checkBox_scaled.Size = new System.Drawing.Size(104, 19);
            this.checkBox_scaled.TabIndex = 7;
            this.checkBox_scaled.TabStop = false;
            this.checkBox_scaled.Text = "Scaled Values";
            this.checkBox_scaled.UseVisualStyleBackColor = true;
            // 
            // button_status2
            // 
            this.button_status2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_status2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_status2.Location = new System.Drawing.Point(393, 359);
            this.button_status2.Margin = new System.Windows.Forms.Padding(1);
            this.button_status2.Name = "button_status2";
            this.button_status2.Size = new System.Drawing.Size(75, 23);
            this.button_status2.TabIndex = 6;
            this.button_status2.Text = "Status";
            this.button_status2.UseVisualStyleBackColor = true;
            this.button_status2.Click += new System.EventHandler(this.button_status_Click);
            this.button_status2.MouseLeave += new System.EventHandler(this.button_status2_MouseLeave);
            this.button_status2.MouseHover += new System.EventHandler(this.button_status2_MouseHover);
            // 
            // button_stopLive
            // 
            this.button_stopLive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_stopLive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_stopLive.Location = new System.Drawing.Point(141, 314);
            this.button_stopLive.Margin = new System.Windows.Forms.Padding(1);
            this.button_stopLive.Name = "button_stopLive";
            this.button_stopLive.Size = new System.Drawing.Size(69, 24);
            this.button_stopLive.TabIndex = 2;
            this.button_stopLive.Text = "Stop";
            this.button_stopLive.UseVisualStyleBackColor = true;
            this.button_stopLive.Click += new System.EventHandler(this.button_stopLive_Click);
            this.button_stopLive.MouseLeave += new System.EventHandler(this.button_stopLive_MouseLeave);
            this.button_stopLive.MouseHover += new System.EventHandler(this.button_stopLive_MouseHover);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_status.Location = new System.Drawing.Point(472, 359);
            this.label_status.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(299, 13);
            this.label_status.TabIndex = 11;
            this.label_status.Text = "Status can be seen in the \"Instrument Configurations\" window";
            this.label_status.Visible = false;
            // 
            // groupBox_scaledValues
            // 
            this.groupBox_scaledValues.Controls.Add(this.listBox_liveDataScaled);
            this.groupBox_scaledValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_scaledValues.Location = new System.Drawing.Point(141, 73);
            this.groupBox_scaledValues.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox_scaledValues.Name = "groupBox_scaledValues";
            this.groupBox_scaledValues.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox_scaledValues.Size = new System.Drawing.Size(96, 175);
            this.groupBox_scaledValues.TabIndex = 12;
            this.groupBox_scaledValues.TabStop = false;
            this.groupBox_scaledValues.Text = "Scaled";
            // 
            // listBox_liveDataScaled
            // 
            this.listBox_liveDataScaled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_liveDataScaled.FormattingEnabled = true;
            this.listBox_liveDataScaled.ItemHeight = 15;
            this.listBox_liveDataScaled.Location = new System.Drawing.Point(6, 16);
            this.listBox_liveDataScaled.Margin = new System.Windows.Forms.Padding(1);
            this.listBox_liveDataScaled.Name = "listBox_liveDataScaled";
            this.listBox_liveDataScaled.Size = new System.Drawing.Size(85, 139);
            this.listBox_liveDataScaled.TabIndex = 6;
            this.listBox_liveDataScaled.TabStop = false;
            // 
            // label_sentToDatabase
            // 
            this.label_sentToDatabase.AutoSize = true;
            this.label_sentToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sentToDatabase.ForeColor = System.Drawing.Color.Red;
            this.label_sentToDatabase.Location = new System.Drawing.Point(23, 400);
            this.label_sentToDatabase.Name = "label_sentToDatabase";
            this.label_sentToDatabase.Size = new System.Drawing.Size(256, 20);
            this.label_sentToDatabase.TabIndex = 13;
            this.label_sentToDatabase.Text = "Data is being sent to database";
            this.label_sentToDatabase.Visible = false;
            // 
            // labelloggingInterval
            // 
            this.labelloggingInterval.AutoSize = true;
            this.labelloggingInterval.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelloggingInterval.Location = new System.Drawing.Point(40, 291);
            this.labelloggingInterval.Name = "labelloggingInterval";
            this.labelloggingInterval.Size = new System.Drawing.Size(228, 13);
            this.labelloggingInterval.TabIndex = 14;
            this.labelloggingInterval.Text = "Using logging frequency from \"interval\" textbox";
            this.labelloggingInterval.Visible = false;
            // 
            // labelStandardInterval
            // 
            this.labelStandardInterval.AutoSize = true;
            this.labelStandardInterval.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStandardInterval.Location = new System.Drawing.Point(40, 291);
            this.labelStandardInterval.Name = "labelStandardInterval";
            this.labelStandardInterval.Size = new System.Drawing.Size(218, 13);
            this.labelStandardInterval.TabIndex = 15;
            this.labelStandardInterval.Text = "Using standard logging frequency (1 second)";
            this.labelStandardInterval.Visible = false;
            // 
            // tabPage_instrumentConfig
            // 
            this.tabPage_instrumentConfig.AutoScroll = true;
            this.tabPage_instrumentConfig.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_instrumentConfig.Controls.Add(this.groupBox_configData);
            this.tabPage_instrumentConfig.Controls.Add(this.gbFilterInstrument);
            this.tabPage_instrumentConfig.Controls.Add(this.button_clear);
            this.tabPage_instrumentConfig.Controls.Add(this.groupBox_values);
            this.tabPage_instrumentConfig.Controls.Add(this.toolStrip_instrumentConf);
            this.tabPage_instrumentConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPage_instrumentConfig.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage_instrumentConfig.Name = "tabPage_instrumentConfig";
            this.tabPage_instrumentConfig.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage_instrumentConfig.Size = new System.Drawing.Size(800, 474);
            this.tabPage_instrumentConfig.TabIndex = 1;
            this.tabPage_instrumentConfig.Text = "3. Instrument Configurations";
            // 
            // toolStrip_instrumentConf
            // 
            this.toolStrip_instrumentConf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_instrumentConf.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip_instrumentConf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_instrumentConfig,
            this.toolStripLabel2_disconnected,
            this.toolStripLabel2_connected});
            this.toolStrip_instrumentConf.Location = new System.Drawing.Point(1, 448);
            this.toolStrip_instrumentConf.Name = "toolStrip_instrumentConf";
            this.toolStrip_instrumentConf.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip_instrumentConf.Size = new System.Drawing.Size(798, 25);
            this.toolStrip_instrumentConf.TabIndex = 18;
            this.toolStrip_instrumentConf.Text = "toolTip";
            // 
            // toolStripLabel_instrumentConfig
            // 
            this.toolStripLabel_instrumentConfig.Name = "toolStripLabel_instrumentConfig";
            this.toolStripLabel_instrumentConfig.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel_instrumentConfig.Text = "ToolTip";
            // 
            // toolStripLabel2_disconnected
            // 
            this.toolStripLabel2_disconnected.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2_disconnected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2_disconnected.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel2_disconnected.Name = "toolStripLabel2_disconnected";
            this.toolStripLabel2_disconnected.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel2_disconnected.Text = "Disconnected";
            this.toolStripLabel2_disconnected.Visible = false;
            // 
            // toolStripLabel2_connected
            // 
            this.toolStripLabel2_connected.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2_connected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2_connected.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripLabel2_connected.Name = "toolStripLabel2_connected";
            this.toolStripLabel2_connected.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel2_connected.Text = "Connected";
            this.toolStripLabel2_connected.Visible = false;
            // 
            // groupBox_values
            // 
            this.groupBox_values.Controls.Add(this.cbLocation);
            this.groupBox_values.Controls.Add(this.cbCompany);
            this.groupBox_values.Controls.Add(this.cbModel);
            this.groupBox_values.Controls.Add(this.label2);
            this.groupBox_values.Controls.Add(this.button_DatabaseConfig);
            this.groupBox_values.Controls.Add(intervalLabel);
            this.groupBox_values.Controls.Add(this.tbInterval);
            this.groupBox_values.Controls.Add(measurementUnitLabel);
            this.groupBox_values.Controls.Add(this.tbUnit);
            this.groupBox_values.Controls.Add(descriptionLabel);
            this.groupBox_values.Controls.Add(this.tbDescription);
            this.groupBox_values.Controls.Add(modelNumberLabel);
            this.groupBox_values.Controls.Add(companyNameLabel);
            this.groupBox_values.Controls.Add(locationLabel);
            this.groupBox_values.Controls.Add(this.comboBox_DAU_ID);
            this.groupBox_values.Controls.Add(this.label1);
            this.groupBox_values.Controls.Add(this.label_tagName);
            this.groupBox_values.Controls.Add(this.textBox_tagName);
            this.groupBox_values.Controls.Add(this.textBox_alarmLow);
            this.groupBox_values.Controls.Add(this.button_status);
            this.groupBox_values.Controls.Add(this.button_write);
            this.groupBox_values.Controls.Add(this.textBox_upperRangeValue);
            this.groupBox_values.Controls.Add(this.textBox_lowerRangeValue);
            this.groupBox_values.Controls.Add(this.textBox_alarmHigh);
            this.groupBox_values.Controls.Add(this.label_LRV);
            this.groupBox_values.Controls.Add(this.button_read);
            this.groupBox_values.Controls.Add(this.label_alarmHigh);
            this.groupBox_values.Controls.Add(this.label_URV);
            this.groupBox_values.Controls.Add(this.label_alarmLow);
            this.groupBox_values.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_values.Location = new System.Drawing.Point(2, 2);
            this.groupBox_values.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox_values.Name = "groupBox_values";
            this.groupBox_values.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox_values.Size = new System.Drawing.Size(588, 226);
            this.groupBox_values.TabIndex = 23;
            this.groupBox_values.TabStop = false;
            this.groupBox_values.Text = "Read and Write Values";
            // 
            // label_alarmLow
            // 
            this.label_alarmLow.AutoSize = true;
            this.label_alarmLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alarmLow.Location = new System.Drawing.Point(4, 101);
            this.label_alarmLow.Name = "label_alarmLow";
            this.label_alarmLow.Size = new System.Drawing.Size(65, 15);
            this.label_alarmLow.TabIndex = 14;
            this.label_alarmLow.Text = "Alarm Low";
            // 
            // label_URV
            // 
            this.label_URV.AutoSize = true;
            this.label_URV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_URV.Location = new System.Drawing.Point(4, 75);
            this.label_URV.Name = "label_URV";
            this.label_URV.Size = new System.Drawing.Size(115, 15);
            this.label_URV.TabIndex = 13;
            this.label_URV.Text = "Upper Range Value";
            // 
            // label_alarmHigh
            // 
            this.label_alarmHigh.AutoSize = true;
            this.label_alarmHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alarmHigh.Location = new System.Drawing.Point(4, 127);
            this.label_alarmHigh.Name = "label_alarmHigh";
            this.label_alarmHigh.Size = new System.Drawing.Size(68, 15);
            this.label_alarmHigh.TabIndex = 15;
            this.label_alarmHigh.Text = "Alarm High";
            // 
            // button_read
            // 
            this.button_read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read.Location = new System.Drawing.Point(4, 156);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(71, 23);
            this.button_read.TabIndex = 15;
            this.button_read.Text = "Read";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            this.button_read.MouseLeave += new System.EventHandler(this.button_sendCommands_MouseLeave);
            this.button_read.MouseHover += new System.EventHandler(this.button_sendCommands_MouseHover);
            // 
            // label_LRV
            // 
            this.label_LRV.AutoSize = true;
            this.label_LRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LRV.Location = new System.Drawing.Point(4, 52);
            this.label_LRV.Name = "label_LRV";
            this.label_LRV.Size = new System.Drawing.Size(115, 15);
            this.label_LRV.TabIndex = 12;
            this.label_LRV.Text = "Lower Range Value";
            // 
            // textBox_alarmHigh
            // 
            this.textBox_alarmHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_alarmHigh.Location = new System.Drawing.Point(125, 127);
            this.textBox_alarmHigh.MaxLength = 4;
            this.textBox_alarmHigh.Name = "textBox_alarmHigh";
            this.textBox_alarmHigh.Size = new System.Drawing.Size(100, 21);
            this.textBox_alarmHigh.TabIndex = 4;
            this.textBox_alarmHigh.TextChanged += new System.EventHandler(this.textBox_alarmHigh_TextChanged);
            this.textBox_alarmHigh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_alarmHigh_KeyPress);
            // 
            // textBox_lowerRangeValue
            // 
            this.textBox_lowerRangeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lowerRangeValue.Location = new System.Drawing.Point(125, 49);
            this.textBox_lowerRangeValue.MaxLength = 4;
            this.textBox_lowerRangeValue.Name = "textBox_lowerRangeValue";
            this.textBox_lowerRangeValue.Size = new System.Drawing.Size(100, 21);
            this.textBox_lowerRangeValue.TabIndex = 1;
            this.textBox_lowerRangeValue.TextChanged += new System.EventHandler(this.textBox_lowerRangeValue_TextChanged);
            this.textBox_lowerRangeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lowerRangeValue_KeyPress);
            // 
            // textBox_upperRangeValue
            // 
            this.textBox_upperRangeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_upperRangeValue.Location = new System.Drawing.Point(125, 75);
            this.textBox_upperRangeValue.MaxLength = 4;
            this.textBox_upperRangeValue.Name = "textBox_upperRangeValue";
            this.textBox_upperRangeValue.Size = new System.Drawing.Size(100, 21);
            this.textBox_upperRangeValue.TabIndex = 2;
            this.textBox_upperRangeValue.TextChanged += new System.EventHandler(this.textBox_upperRangeValue_TextChanged);
            this.textBox_upperRangeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_upperRangeValue_KeyPress);
            // 
            // button_write
            // 
            this.button_write.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write.Location = new System.Drawing.Point(79, 156);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(69, 23);
            this.button_write.TabIndex = 20;
            this.button_write.Text = "Write";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Visible = false;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            this.button_write.MouseLeave += new System.EventHandler(this.button_write_MouseLeave);
            this.button_write.MouseHover += new System.EventHandler(this.button_write_MouseHover);
            // 
            // button_status
            // 
            this.button_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_status.Location = new System.Drawing.Point(152, 156);
            this.button_status.Margin = new System.Windows.Forms.Padding(1);
            this.button_status.Name = "button_status";
            this.button_status.Size = new System.Drawing.Size(73, 23);
            this.button_status.TabIndex = 16;
            this.button_status.Text = "Status";
            this.button_status.UseVisualStyleBackColor = true;
            this.button_status.Click += new System.EventHandler(this.button_status_Click);
            this.button_status.MouseLeave += new System.EventHandler(this.button_status_MouseLeave);
            this.button_status.MouseHover += new System.EventHandler(this.button_status_MouseHover);
            // 
            // textBox_alarmLow
            // 
            this.textBox_alarmLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_alarmLow.Location = new System.Drawing.Point(125, 101);
            this.textBox_alarmLow.MaxLength = 4;
            this.textBox_alarmLow.Name = "textBox_alarmLow";
            this.textBox_alarmLow.Size = new System.Drawing.Size(100, 21);
            this.textBox_alarmLow.TabIndex = 3;
            this.textBox_alarmLow.TextChanged += new System.EventHandler(this.textBox_alarmLow_TextChanged);
            this.textBox_alarmLow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_alarmLow_KeyPress);
            // 
            // textBox_tagName
            // 
            this.textBox_tagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tagName.Location = new System.Drawing.Point(125, 22);
            this.textBox_tagName.MaxLength = 10;
            this.textBox_tagName.Name = "textBox_tagName";
            this.textBox_tagName.Size = new System.Drawing.Size(100, 21);
            this.textBox_tagName.TabIndex = 0;
            this.textBox_tagName.TextChanged += new System.EventHandler(this.textBox_tagName_TextChanged);
            // 
            // label_tagName
            // 
            this.label_tagName.AutoSize = true;
            this.label_tagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tagName.Location = new System.Drawing.Point(4, 26);
            this.label_tagName.Name = "label_tagName";
            this.label_tagName.Size = new System.Drawing.Size(65, 15);
            this.label_tagName.TabIndex = 11;
            this.label_tagName.Text = "Tag Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "DAU:";
            // 
            // comboBox_DAU_ID
            // 
            this.comboBox_DAU_ID.DataSource = this.dAUBindingSource;
            this.comboBox_DAU_ID.DisplayMember = "DeviceName";
            this.comboBox_DAU_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_DAU_ID.FormattingEnabled = true;
            this.comboBox_DAU_ID.Location = new System.Drawing.Point(347, 22);
            this.comboBox_DAU_ID.Name = "comboBox_DAU_ID";
            this.comboBox_DAU_ID.Size = new System.Drawing.Size(100, 23);
            this.comboBox_DAU_ID.TabIndex = 5;
            this.comboBox_DAU_ID.ValueMember = "DAU_ID";
            this.comboBox_DAU_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_DAU_ID_KeyPress);
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.Location = new System.Drawing.Point(245, 157);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(57, 15);
            locationLabel.TabIndex = 42;
            locationLabel.Text = "Location:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyNameLabel.Location = new System.Drawing.Point(245, 131);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(83, 15);
            companyNameLabel.TabIndex = 40;
            companyNameLabel.Text = "Manufacturer:";
            // 
            // modelNumberLabel
            // 
            modelNumberLabel.AutoSize = true;
            modelNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelNumberLabel.Location = new System.Drawing.Point(245, 105);
            modelNumberLabel.Name = "modelNumberLabel";
            modelNumberLabel.Size = new System.Drawing.Size(45, 15);
            modelNumberLabel.TabIndex = 38;
            modelNumberLabel.Text = "Model:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(347, 181);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 40);
            this.tbDescription.TabIndex = 35;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(245, 184);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(72, 15);
            descriptionLabel.TabIndex = 34;
            descriptionLabel.Text = "Description:";
            // 
            // tbUnit
            // 
            this.tbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnit.Location = new System.Drawing.Point(347, 75);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(100, 21);
            this.tbUnit.TabIndex = 33;
            // 
            // measurementUnitLabel
            // 
            measurementUnitLabel.AutoSize = true;
            measurementUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            measurementUnitLabel.Location = new System.Drawing.Point(245, 78);
            measurementUnitLabel.Name = "measurementUnitLabel";
            measurementUnitLabel.Size = new System.Drawing.Size(87, 15);
            measurementUnitLabel.TabIndex = 32;
            measurementUnitLabel.Text = "Measurement:";
            // 
            // tbInterval
            // 
            this.tbInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInterval.Location = new System.Drawing.Point(347, 49);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(100, 21);
            this.tbInterval.TabIndex = 31;
            this.tbInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInterval_KeyPress_1);
            // 
            // intervalLabel
            // 
            intervalLabel.AutoSize = true;
            intervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            intervalLabel.Location = new System.Drawing.Point(245, 49);
            intervalLabel.Name = "intervalLabel";
            intervalLabel.Size = new System.Drawing.Size(49, 15);
            intervalLabel.TabIndex = 30;
            intervalLabel.Text = "Interval:";
            // 
            // button_DatabaseConfig
            // 
            this.button_DatabaseConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DatabaseConfig.Location = new System.Drawing.Point(4, 185);
            this.button_DatabaseConfig.Name = "button_DatabaseConfig";
            this.button_DatabaseConfig.Size = new System.Drawing.Size(221, 23);
            this.button_DatabaseConfig.TabIndex = 19;
            this.button_DatabaseConfig.Text = "Register/Update";
            this.button_DatabaseConfig.UseVisualStyleBackColor = true;
            this.button_DatabaseConfig.Click += new System.EventHandler(this.button_DatabaseConfig_Click);
            this.button_DatabaseConfig.MouseLeave += new System.EventHandler(this.button_DatabaseConfig_MouseLeave);
            this.button_DatabaseConfig.MouseHover += new System.EventHandler(this.button_DatabaseConfig_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(452, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Seconds";
            // 
            // cbModel
            // 
            this.cbModel.DataSource = this.tYPEBindingSource;
            this.cbModel.DisplayMember = "ModelName";
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(347, 101);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(100, 21);
            this.cbModel.TabIndex = 46;
            this.cbModel.ValueMember = "ModelNumber";
            this.cbModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbModel_KeyPress);
            // 
            // cbCompany
            // 
            this.cbCompany.DataSource = this.cOMPANYBindingSource;
            this.cbCompany.DisplayMember = "CompanyName";
            this.cbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(347, 128);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(100, 21);
            this.cbCompany.TabIndex = 47;
            this.cbCompany.ValueMember = "CompanyID";
            this.cbCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCompany_KeyPress);
            // 
            // cbLocation
            // 
            this.cbLocation.DataSource = this.areaBindingSource;
            this.cbLocation.DisplayMember = "Location";
            this.cbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(347, 153);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(100, 21);
            this.cbLocation.TabIndex = 48;
            this.cbLocation.ValueMember = "AreaID";
            this.cbLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLocation_KeyPress);
            // 
            // button_clear
            // 
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(723, 422);
            this.button_clear.Margin = new System.Windows.Forms.Padding(1);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 25);
            this.button_clear.TabIndex = 14;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            this.button_clear.MouseLeave += new System.EventHandler(this.button_clear_MouseLeave);
            this.button_clear.MouseHover += new System.EventHandler(this.button_clear_MouseHover);
            // 
            // gbFilterInstrument
            // 
            this.gbFilterInstrument.Controls.Add(tagNameLabel);
            this.gbFilterInstrument.Controls.Add(this.tagNameTextBox);
            this.gbFilterInstrument.Controls.Add(loweRangeValuesLabel);
            this.gbFilterInstrument.Controls.Add(this.loweRangeValuesTextBox);
            this.gbFilterInstrument.Controls.Add(upperRangeValuesLabel);
            this.gbFilterInstrument.Controls.Add(this.upperRangeValuesTextBox);
            this.gbFilterInstrument.Controls.Add(alarmLowLabel);
            this.gbFilterInstrument.Controls.Add(this.alarmLowTextBox);
            this.gbFilterInstrument.Controls.Add(alarmHighLabel);
            this.gbFilterInstrument.Controls.Add(this.alarmHighTextBox);
            this.gbFilterInstrument.Controls.Add(intervalLabel1);
            this.gbFilterInstrument.Controls.Add(this.intervalTextBox);
            this.gbFilterInstrument.Controls.Add(measurementUnitLabel1);
            this.gbFilterInstrument.Controls.Add(this.measurementUnitTextBox);
            this.gbFilterInstrument.Controls.Add(descriptionLabel3);
            this.gbFilterInstrument.Controls.Add(this.descriptionTextBox2);
            this.gbFilterInstrument.Controls.Add(dAU_IDLabel2);
            this.gbFilterInstrument.Controls.Add(this.dAU_IDTextBox2);
            this.gbFilterInstrument.Controls.Add(modelNumberLabel3);
            this.gbFilterInstrument.Controls.Add(this.modelNumberTextBox);
            this.gbFilterInstrument.Controls.Add(companyIDLabel2);
            this.gbFilterInstrument.Controls.Add(this.companyIDTextBox);
            this.gbFilterInstrument.Controls.Add(areaIDLabel2);
            this.gbFilterInstrument.Controls.Add(this.areaIDTextBox);
            this.gbFilterInstrument.Controls.Add(this.label5);
            this.gbFilterInstrument.Controls.Add(this.cbFindInstrument);
            this.gbFilterInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilterInstrument.Location = new System.Drawing.Point(2, 232);
            this.gbFilterInstrument.Name = "gbFilterInstrument";
            this.gbFilterInstrument.Size = new System.Drawing.Size(588, 186);
            this.gbFilterInstrument.TabIndex = 26;
            this.gbFilterInstrument.TabStop = false;
            this.gbFilterInstrument.Text = "Filter and get data from database";
            // 
            // cbFindInstrument
            // 
            this.cbFindInstrument.DataSource = this.iNSTRUMENT1BindingSource;
            this.cbFindInstrument.DisplayMember = "TagName";
            this.cbFindInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFindInstrument.FormattingEnabled = true;
            this.cbFindInstrument.Location = new System.Drawing.Point(118, 22);
            this.cbFindInstrument.Name = "cbFindInstrument";
            this.cbFindInstrument.Size = new System.Drawing.Size(98, 21);
            this.cbFindInstrument.TabIndex = 25;
            this.cbFindInstrument.ValueMember = "TagName";
            this.cbFindInstrument.SelectedIndexChanged += new System.EventHandler(this.cbFindInstrument_SelectedIndexChanged);
            this.cbFindInstrument.Enter += new System.EventHandler(this.cbFindInstrument_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Find Device:";
            // 
            // areaIDTextBox
            // 
            this.areaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "AreaID", true));
            this.areaIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaIDTextBox.Location = new System.Drawing.Point(476, 82);
            this.areaIDTextBox.Name = "areaIDTextBox";
            this.areaIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaIDTextBox.TabIndex = 49;
            // 
            // areaIDLabel2
            // 
            areaIDLabel2.AutoSize = true;
            areaIDLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            areaIDLabel2.Location = new System.Drawing.Point(402, 83);
            areaIDLabel2.Name = "areaIDLabel2";
            areaIDLabel2.Size = new System.Drawing.Size(46, 13);
            areaIDLabel2.TabIndex = 48;
            areaIDLabel2.Text = "Area ID:";
            // 
            // companyIDTextBox
            // 
            this.companyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "CompanyID", true));
            this.companyIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyIDTextBox.Location = new System.Drawing.Point(476, 56);
            this.companyIDTextBox.Name = "companyIDTextBox";
            this.companyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyIDTextBox.TabIndex = 47;
            // 
            // companyIDLabel2
            // 
            companyIDLabel2.AutoSize = true;
            companyIDLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyIDLabel2.Location = new System.Drawing.Point(402, 59);
            companyIDLabel2.Name = "companyIDLabel2";
            companyIDLabel2.Size = new System.Drawing.Size(68, 13);
            companyIDLabel2.TabIndex = 46;
            companyIDLabel2.Text = "Company ID:";
            // 
            // modelNumberTextBox
            // 
            this.modelNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "ModelNumber", true));
            this.modelNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelNumberTextBox.Location = new System.Drawing.Point(296, 59);
            this.modelNumberTextBox.Name = "modelNumberTextBox";
            this.modelNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelNumberTextBox.TabIndex = 45;
            // 
            // modelNumberLabel3
            // 
            modelNumberLabel3.AutoSize = true;
            modelNumberLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelNumberLabel3.Location = new System.Drawing.Point(221, 63);
            modelNumberLabel3.Name = "modelNumberLabel3";
            modelNumberLabel3.Size = new System.Drawing.Size(56, 13);
            modelNumberLabel3.TabIndex = 44;
            modelNumberLabel3.Text = "Model No:";
            // 
            // dAU_IDTextBox2
            // 
            this.dAU_IDTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "DAU_ID", true));
            this.dAU_IDTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dAU_IDTextBox2.Location = new System.Drawing.Point(476, 107);
            this.dAU_IDTextBox2.Name = "dAU_IDTextBox2";
            this.dAU_IDTextBox2.Size = new System.Drawing.Size(100, 20);
            this.dAU_IDTextBox2.TabIndex = 43;
            // 
            // dAU_IDLabel2
            // 
            dAU_IDLabel2.AutoSize = true;
            dAU_IDLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dAU_IDLabel2.Location = new System.Drawing.Point(401, 112);
            dAU_IDLabel2.Name = "dAU_IDLabel2";
            dAU_IDLabel2.Size = new System.Drawing.Size(47, 13);
            dAU_IDLabel2.TabIndex = 42;
            dAU_IDLabel2.Text = "DAU ID:";
            // 
            // descriptionTextBox2
            // 
            this.descriptionTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Description", true));
            this.descriptionTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox2.Location = new System.Drawing.Point(476, 133);
            this.descriptionTextBox2.Multiline = true;
            this.descriptionTextBox2.Name = "descriptionTextBox2";
            this.descriptionTextBox2.Size = new System.Drawing.Size(100, 48);
            this.descriptionTextBox2.TabIndex = 41;
            // 
            // descriptionLabel3
            // 
            descriptionLabel3.AutoSize = true;
            descriptionLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel3.Location = new System.Drawing.Point(401, 140);
            descriptionLabel3.Name = "descriptionLabel3";
            descriptionLabel3.Size = new System.Drawing.Size(63, 13);
            descriptionLabel3.TabIndex = 40;
            descriptionLabel3.Text = "Description:";
            // 
            // measurementUnitTextBox
            // 
            this.measurementUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "MeasurementUnit", true));
            this.measurementUnitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementUnitTextBox.Location = new System.Drawing.Point(118, 134);
            this.measurementUnitTextBox.Name = "measurementUnitTextBox";
            this.measurementUnitTextBox.Size = new System.Drawing.Size(98, 20);
            this.measurementUnitTextBox.TabIndex = 39;
            // 
            // measurementUnitLabel1
            // 
            measurementUnitLabel1.AutoSize = true;
            measurementUnitLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            measurementUnitLabel1.Location = new System.Drawing.Point(7, 139);
            measurementUnitLabel1.Name = "measurementUnitLabel1";
            measurementUnitLabel1.Size = new System.Drawing.Size(96, 13);
            measurementUnitLabel1.TabIndex = 38;
            measurementUnitLabel1.Text = "Measurement Unit:";
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Interval", true));
            this.intervalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalTextBox.Location = new System.Drawing.Point(296, 135);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(100, 20);
            this.intervalTextBox.TabIndex = 37;
            // 
            // intervalLabel1
            // 
            intervalLabel1.AutoSize = true;
            intervalLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            intervalLabel1.Location = new System.Drawing.Point(221, 140);
            intervalLabel1.Name = "intervalLabel1";
            intervalLabel1.Size = new System.Drawing.Size(45, 13);
            intervalLabel1.TabIndex = 36;
            intervalLabel1.Text = "Interval:";
            // 
            // alarmHighTextBox
            // 
            this.alarmHighTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "AlarmHigh", true));
            this.alarmHighTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmHighTextBox.Location = new System.Drawing.Point(296, 109);
            this.alarmHighTextBox.Name = "alarmHighTextBox";
            this.alarmHighTextBox.Size = new System.Drawing.Size(100, 20);
            this.alarmHighTextBox.TabIndex = 35;
            // 
            // alarmHighLabel
            // 
            alarmHighLabel.AutoSize = true;
            alarmHighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alarmHighLabel.Location = new System.Drawing.Point(221, 118);
            alarmHighLabel.Name = "alarmHighLabel";
            alarmHighLabel.Size = new System.Drawing.Size(61, 13);
            alarmHighLabel.TabIndex = 34;
            alarmHighLabel.Text = "Alarm High:";
            // 
            // alarmLowTextBox
            // 
            this.alarmLowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "AlarmLow", true));
            this.alarmLowTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmLowTextBox.Location = new System.Drawing.Point(296, 83);
            this.alarmLowTextBox.Name = "alarmLowTextBox";
            this.alarmLowTextBox.Size = new System.Drawing.Size(100, 20);
            this.alarmLowTextBox.TabIndex = 33;
            // 
            // alarmLowLabel
            // 
            alarmLowLabel.AutoSize = true;
            alarmLowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alarmLowLabel.Location = new System.Drawing.Point(221, 90);
            alarmLowLabel.Name = "alarmLowLabel";
            alarmLowLabel.Size = new System.Drawing.Size(59, 13);
            alarmLowLabel.TabIndex = 32;
            alarmLowLabel.Text = "Alarm Low:";
            // 
            // upperRangeValuesTextBox
            // 
            this.upperRangeValuesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "UpperRangeValues", true));
            this.upperRangeValuesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperRangeValuesTextBox.Location = new System.Drawing.Point(118, 108);
            this.upperRangeValuesTextBox.Name = "upperRangeValuesTextBox";
            this.upperRangeValuesTextBox.Size = new System.Drawing.Size(98, 20);
            this.upperRangeValuesTextBox.TabIndex = 31;
            // 
            // upperRangeValuesLabel
            // 
            upperRangeValuesLabel.AutoSize = true;
            upperRangeValuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            upperRangeValuesLabel.Location = new System.Drawing.Point(5, 114);
            upperRangeValuesLabel.Name = "upperRangeValuesLabel";
            upperRangeValuesLabel.Size = new System.Drawing.Size(109, 13);
            upperRangeValuesLabel.TabIndex = 30;
            upperRangeValuesLabel.Text = "Upper Range Values:";
            // 
            // loweRangeValuesTextBox
            // 
            this.loweRangeValuesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "LoweRangeValues", true));
            this.loweRangeValuesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loweRangeValuesTextBox.Location = new System.Drawing.Point(118, 82);
            this.loweRangeValuesTextBox.Name = "loweRangeValuesTextBox";
            this.loweRangeValuesTextBox.Size = new System.Drawing.Size(98, 20);
            this.loweRangeValuesTextBox.TabIndex = 29;
            // 
            // loweRangeValuesLabel
            // 
            loweRangeValuesLabel.AutoSize = true;
            loweRangeValuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loweRangeValuesLabel.Location = new System.Drawing.Point(4, 81);
            loweRangeValuesLabel.Name = "loweRangeValuesLabel";
            loweRangeValuesLabel.Size = new System.Drawing.Size(106, 13);
            loweRangeValuesLabel.TabIndex = 28;
            loweRangeValuesLabel.Text = "Lowe Range Values:";
            // 
            // tagNameTextBox
            // 
            this.tagNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "TagName", true));
            this.tagNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagNameTextBox.Location = new System.Drawing.Point(118, 56);
            this.tagNameTextBox.Name = "tagNameTextBox";
            this.tagNameTextBox.Size = new System.Drawing.Size(98, 20);
            this.tagNameTextBox.TabIndex = 27;
            // 
            // tagNameLabel
            // 
            tagNameLabel.AutoSize = true;
            tagNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tagNameLabel.Location = new System.Drawing.Point(7, 59);
            tagNameLabel.Name = "tagNameLabel";
            tagNameLabel.Size = new System.Drawing.Size(60, 13);
            tagNameLabel.TabIndex = 26;
            tagNameLabel.Text = "Tag Name:";
            // 
            // groupBox_configData
            // 
            this.groupBox_configData.Controls.Add(this.textBox_showConfigurations);
            this.groupBox_configData.Controls.Add(this.button_loadValue);
            this.groupBox_configData.Controls.Add(this.button_saveConfigurations);
            this.groupBox_configData.Controls.Add(this.button_raw);
            this.groupBox_configData.Controls.Add(this.button_scaled);
            this.groupBox_configData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_configData.Location = new System.Drawing.Point(594, 2);
            this.groupBox_configData.Name = "groupBox_configData";
            this.groupBox_configData.Size = new System.Drawing.Size(198, 284);
            this.groupBox_configData.TabIndex = 27;
            this.groupBox_configData.TabStop = false;
            this.groupBox_configData.Text = "Configuration Data";
            // 
            // button_scaled
            // 
            this.button_scaled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_scaled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scaled.Location = new System.Drawing.Point(7, 255);
            this.button_scaled.Margin = new System.Windows.Forms.Padding(1);
            this.button_scaled.Name = "button_scaled";
            this.button_scaled.Size = new System.Drawing.Size(75, 23);
            this.button_scaled.TabIndex = 18;
            this.button_scaled.Text = "Scaled Data";
            this.button_scaled.UseVisualStyleBackColor = true;
            this.button_scaled.Click += new System.EventHandler(this.button_scaled_Click);
            this.button_scaled.MouseLeave += new System.EventHandler(this.button_scaled_MouseLeave);
            this.button_scaled.MouseHover += new System.EventHandler(this.button_scaled_MouseHover);
            // 
            // button_raw
            // 
            this.button_raw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_raw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_raw.Location = new System.Drawing.Point(117, 255);
            this.button_raw.Margin = new System.Windows.Forms.Padding(1);
            this.button_raw.Name = "button_raw";
            this.button_raw.Size = new System.Drawing.Size(75, 23);
            this.button_raw.TabIndex = 17;
            this.button_raw.Text = "Raw data";
            this.button_raw.UseVisualStyleBackColor = true;
            this.button_raw.Click += new System.EventHandler(this.button_raw_Click);
            this.button_raw.MouseLeave += new System.EventHandler(this.button_raw_MouseLeave);
            this.button_raw.MouseHover += new System.EventHandler(this.button_raw_MouseHover);
            // 
            // button_saveConfigurations
            // 
            this.button_saveConfigurations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_saveConfigurations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveConfigurations.Location = new System.Drawing.Point(7, 228);
            this.button_saveConfigurations.Name = "button_saveConfigurations";
            this.button_saveConfigurations.Size = new System.Drawing.Size(75, 23);
            this.button_saveConfigurations.TabIndex = 13;
            this.button_saveConfigurations.Text = "Save";
            this.button_saveConfigurations.UseVisualStyleBackColor = true;
            this.button_saveConfigurations.Click += new System.EventHandler(this.button_saveConfigurations_Click);
            this.button_saveConfigurations.MouseLeave += new System.EventHandler(this.button_saveConfigurations_MouseLeave);
            this.button_saveConfigurations.MouseHover += new System.EventHandler(this.button_saveConfigurations_MouseHover);
            // 
            // button_loadValue
            // 
            this.button_loadValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_loadValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_loadValue.Location = new System.Drawing.Point(117, 228);
            this.button_loadValue.Name = "button_loadValue";
            this.button_loadValue.Size = new System.Drawing.Size(75, 23);
            this.button_loadValue.TabIndex = 12;
            this.button_loadValue.Text = "Load";
            this.button_loadValue.UseVisualStyleBackColor = true;
            this.button_loadValue.Click += new System.EventHandler(this.button_loadValue_Click);
            this.button_loadValue.MouseLeave += new System.EventHandler(this.button_loadValue_MouseLeave);
            this.button_loadValue.MouseHover += new System.EventHandler(this.button_loadValue_MouseHover);
            // 
            // textBox_showConfigurations
            // 
            this.textBox_showConfigurations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_showConfigurations.Location = new System.Drawing.Point(7, 17);
            this.textBox_showConfigurations.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_showConfigurations.Multiline = true;
            this.textBox_showConfigurations.Name = "textBox_showConfigurations";
            this.textBox_showConfigurations.ReadOnly = true;
            this.textBox_showConfigurations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_showConfigurations.Size = new System.Drawing.Size(187, 207);
            this.textBox_showConfigurations.TabIndex = 4;
            this.textBox_showConfigurations.TabStop = false;
            // 
            // tabPage_DAU
            // 
            this.tabPage_DAU.AutoScroll = true;
            this.tabPage_DAU.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_DAU.Controls.Add(this.groupBoxDAURegUpd);
            this.tabPage_DAU.Controls.Add(this.btnClearDAU);
            this.tabPage_DAU.Controls.Add(this.btnUpdateDAU);
            this.tabPage_DAU.Controls.Add(this.groupBox_DAUFiltering);
            this.tabPage_DAU.Controls.Add(this.toolStrip_InputOutput);
            this.tabPage_DAU.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DAU.Name = "tabPage_DAU";
            this.tabPage_DAU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DAU.Size = new System.Drawing.Size(800, 474);
            this.tabPage_DAU.TabIndex = 3;
            this.tabPage_DAU.Text = "2. DAU Database";
            // 
            // toolStrip_InputOutput
            // 
            this.toolStrip_InputOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_InputOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4_disconnected,
            this.toolStripLabel4_connected,
            this.toolStripLabelDAU});
            this.toolStrip_InputOutput.Location = new System.Drawing.Point(3, 446);
            this.toolStrip_InputOutput.Name = "toolStrip_InputOutput";
            this.toolStrip_InputOutput.Size = new System.Drawing.Size(794, 25);
            this.toolStrip_InputOutput.TabIndex = 0;
            this.toolStrip_InputOutput.Text = "ToolStrip_InputOutput";
            // 
            // toolStripLabel4_disconnected
            // 
            this.toolStripLabel4_disconnected.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4_disconnected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4_disconnected.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel4_disconnected.Name = "toolStripLabel4_disconnected";
            this.toolStripLabel4_disconnected.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel4_disconnected.Text = "Disconnected";
            this.toolStripLabel4_disconnected.Visible = false;
            // 
            // toolStripLabel4_connected
            // 
            this.toolStripLabel4_connected.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4_connected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4_connected.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripLabel4_connected.Name = "toolStripLabel4_connected";
            this.toolStripLabel4_connected.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel4_connected.Text = "Connected";
            this.toolStripLabel4_connected.Visible = false;
            // 
            // toolStripLabelDAU
            // 
            this.toolStripLabelDAU.Name = "toolStripLabelDAU";
            this.toolStripLabelDAU.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabelDAU.Text = "toolStripLabel2";
            // 
            // groupBox_DAUFiltering
            // 
            this.groupBox_DAUFiltering.Controls.Add(this.computer_IDTextBox);
            this.groupBox_DAUFiltering.Controls.Add(this.label4);
            this.groupBox_DAUFiltering.Controls.Add(this.tbLocation);
            this.groupBox_DAUFiltering.Controls.Add(this.tbCompany);
            this.groupBox_DAUFiltering.Controls.Add(this.tbModel);
            this.groupBox_DAUFiltering.Controls.Add(this.cbFindDeviceDAU);
            this.groupBox_DAUFiltering.Controls.Add(this.label3);
            this.groupBox_DAUFiltering.Controls.Add(dAU_IDLabel);
            this.groupBox_DAUFiltering.Controls.Add(this.dAU_IDTextBox);
            this.groupBox_DAUFiltering.Controls.Add(deviceNameLabel);
            this.groupBox_DAUFiltering.Controls.Add(this.deviceNameTextBox);
            this.groupBox_DAUFiltering.Controls.Add(baud_rateLabel);
            this.groupBox_DAUFiltering.Controls.Add(this.baud_rateTextBox);
            this.groupBox_DAUFiltering.Controls.Add(data_bitsLabel);
            this.groupBox_DAUFiltering.Controls.Add(this.data_bitsTextBox);
            this.groupBox_DAUFiltering.Controls.Add(parityLabel);
            this.groupBox_DAUFiltering.Controls.Add(this.parityTextBox);
            this.groupBox_DAUFiltering.Controls.Add(stop_bitLabel);
            this.groupBox_DAUFiltering.Controls.Add(this.stop_bitTextBox);
            this.groupBox_DAUFiltering.Controls.Add(descriptionLabel1);
            this.groupBox_DAUFiltering.Controls.Add(this.descriptionTextBox);
            this.groupBox_DAUFiltering.Controls.Add(modelNumberLabel1);
            this.groupBox_DAUFiltering.Controls.Add(companyIDLabel);
            this.groupBox_DAUFiltering.Controls.Add(areaIDLabel);
            this.groupBox_DAUFiltering.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DAUFiltering.Location = new System.Drawing.Point(129, 26);
            this.groupBox_DAUFiltering.Name = "groupBox_DAUFiltering";
            this.groupBox_DAUFiltering.Size = new System.Drawing.Size(218, 403);
            this.groupBox_DAUFiltering.TabIndex = 1;
            this.groupBox_DAUFiltering.TabStop = false;
            this.groupBox_DAUFiltering.Text = "Filtering from Database";
            // 
            // areaIDLabel
            // 
            areaIDLabel.AutoSize = true;
            areaIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            areaIDLabel.Location = new System.Drawing.Point(5, 334);
            areaIDLabel.Name = "areaIDLabel";
            areaIDLabel.Size = new System.Drawing.Size(51, 13);
            areaIDLabel.TabIndex = 20;
            areaIDLabel.Text = "Location:";
            // 
            // companyIDLabel
            // 
            companyIDLabel.AutoSize = true;
            companyIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyIDLabel.Location = new System.Drawing.Point(5, 307);
            companyIDLabel.Name = "companyIDLabel";
            companyIDLabel.Size = new System.Drawing.Size(73, 13);
            companyIDLabel.TabIndex = 18;
            companyIDLabel.Text = "Manufacturer:";
            // 
            // modelNumberLabel1
            // 
            modelNumberLabel1.AutoSize = true;
            modelNumberLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelNumberLabel1.Location = new System.Drawing.Point(5, 280);
            modelNumberLabel1.Name = "modelNumberLabel1";
            modelNumberLabel1.Size = new System.Drawing.Size(39, 13);
            modelNumberLabel1.TabIndex = 16;
            modelNumberLabel1.Text = "Model:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(103, 350);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 45);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel1.Location = new System.Drawing.Point(5, 353);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(63, 13);
            descriptionLabel1.TabIndex = 12;
            descriptionLabel1.Text = "Description:";
            // 
            // stop_bitTextBox
            // 
            this.stop_bitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Stop_bit", true));
            this.stop_bitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_bitTextBox.Location = new System.Drawing.Point(104, 214);
            this.stop_bitTextBox.Name = "stop_bitTextBox";
            this.stop_bitTextBox.Size = new System.Drawing.Size(100, 20);
            this.stop_bitTextBox.TabIndex = 11;
            // 
            // stop_bitLabel
            // 
            stop_bitLabel.AutoSize = true;
            stop_bitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stop_bitLabel.Location = new System.Drawing.Point(6, 221);
            stop_bitLabel.Name = "stop_bitLabel";
            stop_bitLabel.Size = new System.Drawing.Size(46, 13);
            stop_bitLabel.TabIndex = 10;
            stop_bitLabel.Text = "Stop bit:";
            // 
            // parityTextBox
            // 
            this.parityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Parity", true));
            this.parityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parityTextBox.Location = new System.Drawing.Point(104, 188);
            this.parityTextBox.Name = "parityTextBox";
            this.parityTextBox.Size = new System.Drawing.Size(100, 20);
            this.parityTextBox.TabIndex = 9;
            // 
            // parityLabel
            // 
            parityLabel.AutoSize = true;
            parityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            parityLabel.Location = new System.Drawing.Point(6, 195);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new System.Drawing.Size(36, 13);
            parityLabel.TabIndex = 8;
            parityLabel.Text = "Parity:";
            // 
            // data_bitsTextBox
            // 
            this.data_bitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Data_bits", true));
            this.data_bitsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_bitsTextBox.Location = new System.Drawing.Point(104, 162);
            this.data_bitsTextBox.Name = "data_bitsTextBox";
            this.data_bitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_bitsTextBox.TabIndex = 7;
            // 
            // data_bitsLabel
            // 
            data_bitsLabel.AutoSize = true;
            data_bitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_bitsLabel.Location = new System.Drawing.Point(6, 169);
            data_bitsLabel.Name = "data_bitsLabel";
            data_bitsLabel.Size = new System.Drawing.Size(52, 13);
            data_bitsLabel.TabIndex = 6;
            data_bitsLabel.Text = "Data bits:";
            // 
            // baud_rateTextBox
            // 
            this.baud_rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Baud_rate", true));
            this.baud_rateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baud_rateTextBox.Location = new System.Drawing.Point(104, 136);
            this.baud_rateTextBox.Name = "baud_rateTextBox";
            this.baud_rateTextBox.Size = new System.Drawing.Size(100, 20);
            this.baud_rateTextBox.TabIndex = 5;
            // 
            // baud_rateLabel
            // 
            baud_rateLabel.AutoSize = true;
            baud_rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            baud_rateLabel.Location = new System.Drawing.Point(5, 143);
            baud_rateLabel.Name = "baud_rateLabel";
            baud_rateLabel.Size = new System.Drawing.Size(56, 13);
            baud_rateLabel.TabIndex = 4;
            baud_rateLabel.Text = "Baud rate:";
            // 
            // deviceNameTextBox
            // 
            this.deviceNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "DeviceName", true));
            this.deviceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNameTextBox.Location = new System.Drawing.Point(104, 110);
            this.deviceNameTextBox.Name = "deviceNameTextBox";
            this.deviceNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.deviceNameTextBox.TabIndex = 3;
            // 
            // deviceNameLabel
            // 
            deviceNameLabel.AutoSize = true;
            deviceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deviceNameLabel.Location = new System.Drawing.Point(6, 117);
            deviceNameLabel.Name = "deviceNameLabel";
            deviceNameLabel.Size = new System.Drawing.Size(75, 13);
            deviceNameLabel.TabIndex = 2;
            deviceNameLabel.Text = "Device Name:";
            // 
            // dAU_IDTextBox
            // 
            this.dAU_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "DAU_ID", true));
            this.dAU_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dAU_IDTextBox.Location = new System.Drawing.Point(104, 84);
            this.dAU_IDTextBox.Name = "dAU_IDTextBox";
            this.dAU_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.dAU_IDTextBox.TabIndex = 1;
            // 
            // dAU_IDLabel
            // 
            dAU_IDLabel.AutoSize = true;
            dAU_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dAU_IDLabel.Location = new System.Drawing.Point(5, 91);
            dAU_IDLabel.Name = "dAU_IDLabel";
            dAU_IDLabel.Size = new System.Drawing.Size(47, 13);
            dAU_IDLabel.TabIndex = 0;
            dAU_IDLabel.Text = "DAU ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Find Device:";
            // 
            // cbFindDeviceDAU
            // 
            this.cbFindDeviceDAU.DataSource = this.dAU1BindingSource;
            this.cbFindDeviceDAU.DisplayMember = "DeviceName";
            this.cbFindDeviceDAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFindDeviceDAU.FormattingEnabled = true;
            this.cbFindDeviceDAU.Location = new System.Drawing.Point(104, 20);
            this.cbFindDeviceDAU.Name = "cbFindDeviceDAU";
            this.cbFindDeviceDAU.Size = new System.Drawing.Size(100, 21);
            this.cbFindDeviceDAU.TabIndex = 26;
            this.cbFindDeviceDAU.ValueMember = "DAU_ID";
            this.cbFindDeviceDAU.SelectedIndexChanged += new System.EventHandler(this.cbFindDeviceDAU_SelectedIndexChanged);
            this.cbFindDeviceDAU.Enter += new System.EventHandler(this.cbFindDeviceDAU_Enter);
            this.cbFindDeviceDAU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFindDeviceDAU_KeyPress);
            // 
            // tbModel
            // 
            this.tbModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "ModelNumber", true));
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(103, 272);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 20);
            this.tbModel.TabIndex = 27;
            // 
            // tbCompany
            // 
            this.tbCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "CompanyID", true));
            this.tbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompany.Location = new System.Drawing.Point(103, 299);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(100, 20);
            this.tbCompany.TabIndex = 28;
            // 
            // tbLocation
            // 
            this.tbLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "AreaID", true));
            this.tbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(103, 326);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(100, 20);
            this.tbLocation.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "RDC ID:";
            // 
            // computer_IDTextBox
            // 
            this.computer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Computer_ID", true));
            this.computer_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer_IDTextBox.Location = new System.Drawing.Point(104, 246);
            this.computer_IDTextBox.Name = "computer_IDTextBox";
            this.computer_IDTextBox.Size = new System.Drawing.Size(99, 20);
            this.computer_IDTextBox.TabIndex = 31;
            // 
            // btnUpdateDAU
            // 
            this.btnUpdateDAU.Location = new System.Drawing.Point(603, 96);
            this.btnUpdateDAU.Name = "btnUpdateDAU";
            this.btnUpdateDAU.Size = new System.Drawing.Size(95, 27);
            this.btnUpdateDAU.TabIndex = 2;
            this.btnUpdateDAU.Text = "Register/Update";
            this.btnUpdateDAU.UseVisualStyleBackColor = true;
            this.btnUpdateDAU.Click += new System.EventHandler(this.btnUpdateDAU_Click);
            this.btnUpdateDAU.MouseLeave += new System.EventHandler(this.btnUpdateDAU_MouseLeave);
            this.btnUpdateDAU.MouseHover += new System.EventHandler(this.btnUpdateDAU_MouseHover);
            // 
            // btnClearDAU
            // 
            this.btnClearDAU.Location = new System.Drawing.Point(603, 129);
            this.btnClearDAU.Name = "btnClearDAU";
            this.btnClearDAU.Size = new System.Drawing.Size(95, 27);
            this.btnClearDAU.TabIndex = 3;
            this.btnClearDAU.Text = "Clear";
            this.btnClearDAU.UseVisualStyleBackColor = true;
            this.btnClearDAU.Click += new System.EventHandler(this.btnClearDAU_Click);
            this.btnClearDAU.MouseLeave += new System.EventHandler(this.btnClearDAU_MouseLeave);
            this.btnClearDAU.MouseHover += new System.EventHandler(this.btnClearDAU_MouseHover);
            // 
            // groupBoxDAURegUpd
            // 
            this.groupBoxDAURegUpd.Controls.Add(this.cbLocationDAU);
            this.groupBoxDAURegUpd.Controls.Add(this.cbCompanyDAU);
            this.groupBoxDAURegUpd.Controls.Add(this.cbModelDAU);
            this.groupBoxDAURegUpd.Controls.Add(this.cbRDCdau);
            this.groupBoxDAURegUpd.Controls.Add(dAU_IDLabel1);
            this.groupBoxDAURegUpd.Controls.Add(this.dAU_IDTextBox1);
            this.groupBoxDAURegUpd.Controls.Add(deviceNameLabel1);
            this.groupBoxDAURegUpd.Controls.Add(this.deviceNameTextBox1);
            this.groupBoxDAURegUpd.Controls.Add(baud_rateLabel1);
            this.groupBoxDAURegUpd.Controls.Add(this.baud_rateTextBox1);
            this.groupBoxDAURegUpd.Controls.Add(data_bitsLabel1);
            this.groupBoxDAURegUpd.Controls.Add(this.data_bitsTextBox1);
            this.groupBoxDAURegUpd.Controls.Add(parityLabel1);
            this.groupBoxDAURegUpd.Controls.Add(this.parityTextBox1);
            this.groupBoxDAURegUpd.Controls.Add(stop_bitLabel1);
            this.groupBoxDAURegUpd.Controls.Add(this.stop_bitTextBox1);
            this.groupBoxDAURegUpd.Controls.Add(descriptionLabel2);
            this.groupBoxDAURegUpd.Controls.Add(this.descriptionTextBox1);
            this.groupBoxDAURegUpd.Controls.Add(computer_IDLabel);
            this.groupBoxDAURegUpd.Controls.Add(modelNumberLabel2);
            this.groupBoxDAURegUpd.Controls.Add(companyIDLabel1);
            this.groupBoxDAURegUpd.Controls.Add(areaIDLabel1);
            this.groupBoxDAURegUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDAURegUpd.Location = new System.Drawing.Point(380, 26);
            this.groupBoxDAURegUpd.Name = "groupBoxDAURegUpd";
            this.groupBoxDAURegUpd.Size = new System.Drawing.Size(217, 403);
            this.groupBoxDAURegUpd.TabIndex = 25;
            this.groupBoxDAURegUpd.TabStop = false;
            this.groupBoxDAURegUpd.Text = "Registration and Update to Database";
            // 
            // areaIDLabel1
            // 
            areaIDLabel1.AutoSize = true;
            areaIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            areaIDLabel1.Location = new System.Drawing.Point(6, 324);
            areaIDLabel1.Name = "areaIDLabel1";
            areaIDLabel1.Size = new System.Drawing.Size(51, 13);
            areaIDLabel1.TabIndex = 20;
            areaIDLabel1.Text = "Location:";
            // 
            // companyIDLabel1
            // 
            companyIDLabel1.AutoSize = true;
            companyIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyIDLabel1.Location = new System.Drawing.Point(6, 292);
            companyIDLabel1.Name = "companyIDLabel1";
            companyIDLabel1.Size = new System.Drawing.Size(73, 13);
            companyIDLabel1.TabIndex = 18;
            companyIDLabel1.Text = "Manufacturer:";
            // 
            // modelNumberLabel2
            // 
            modelNumberLabel2.AutoSize = true;
            modelNumberLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelNumberLabel2.Location = new System.Drawing.Point(6, 266);
            modelNumberLabel2.Name = "modelNumberLabel2";
            modelNumberLabel2.Size = new System.Drawing.Size(39, 13);
            modelNumberLabel2.TabIndex = 16;
            modelNumberLabel2.Text = "Model:";
            // 
            // computer_IDLabel
            // 
            computer_IDLabel.AutoSize = true;
            computer_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            computer_IDLabel.Location = new System.Drawing.Point(6, 240);
            computer_IDLabel.Name = "computer_IDLabel";
            computer_IDLabel.Size = new System.Drawing.Size(47, 13);
            computer_IDLabel.TabIndex = 14;
            computer_IDLabel.Text = "RDC ID:";
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox1.Location = new System.Drawing.Point(104, 347);
            this.descriptionTextBox1.Multiline = true;
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(95, 50);
            this.descriptionTextBox1.TabIndex = 13;
            this.descriptionTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descriptionTextBox1_KeyPress);
            // 
            // descriptionLabel2
            // 
            descriptionLabel2.AutoSize = true;
            descriptionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel2.Location = new System.Drawing.Point(6, 353);
            descriptionLabel2.Name = "descriptionLabel2";
            descriptionLabel2.Size = new System.Drawing.Size(63, 13);
            descriptionLabel2.TabIndex = 12;
            descriptionLabel2.Text = "Description:";
            // 
            // stop_bitTextBox1
            // 
            this.stop_bitTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_bitTextBox1.Location = new System.Drawing.Point(104, 211);
            this.stop_bitTextBox1.Name = "stop_bitTextBox1";
            this.stop_bitTextBox1.Size = new System.Drawing.Size(95, 20);
            this.stop_bitTextBox1.TabIndex = 11;
            this.stop_bitTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stop_bitTextBox1_KeyPress);
            // 
            // stop_bitLabel1
            // 
            stop_bitLabel1.AutoSize = true;
            stop_bitLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stop_bitLabel1.Location = new System.Drawing.Point(6, 214);
            stop_bitLabel1.Name = "stop_bitLabel1";
            stop_bitLabel1.Size = new System.Drawing.Size(46, 13);
            stop_bitLabel1.TabIndex = 10;
            stop_bitLabel1.Text = "Stop bit:";
            // 
            // parityTextBox1
            // 
            this.parityTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parityTextBox1.Location = new System.Drawing.Point(104, 185);
            this.parityTextBox1.Name = "parityTextBox1";
            this.parityTextBox1.Size = new System.Drawing.Size(95, 20);
            this.parityTextBox1.TabIndex = 9;
            this.parityTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parityTextBox1_KeyPress);
            // 
            // parityLabel1
            // 
            parityLabel1.AutoSize = true;
            parityLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            parityLabel1.Location = new System.Drawing.Point(6, 188);
            parityLabel1.Name = "parityLabel1";
            parityLabel1.Size = new System.Drawing.Size(36, 13);
            parityLabel1.TabIndex = 8;
            parityLabel1.Text = "Parity:";
            // 
            // data_bitsTextBox1
            // 
            this.data_bitsTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_bitsTextBox1.Location = new System.Drawing.Point(104, 159);
            this.data_bitsTextBox1.Name = "data_bitsTextBox1";
            this.data_bitsTextBox1.Size = new System.Drawing.Size(95, 20);
            this.data_bitsTextBox1.TabIndex = 7;
            this.data_bitsTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.data_bitsTextBox1_KeyPress);
            // 
            // data_bitsLabel1
            // 
            data_bitsLabel1.AutoSize = true;
            data_bitsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_bitsLabel1.Location = new System.Drawing.Point(6, 162);
            data_bitsLabel1.Name = "data_bitsLabel1";
            data_bitsLabel1.Size = new System.Drawing.Size(52, 13);
            data_bitsLabel1.TabIndex = 6;
            data_bitsLabel1.Text = "Data bits:";
            // 
            // baud_rateTextBox1
            // 
            this.baud_rateTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baud_rateTextBox1.Location = new System.Drawing.Point(104, 133);
            this.baud_rateTextBox1.Name = "baud_rateTextBox1";
            this.baud_rateTextBox1.Size = new System.Drawing.Size(95, 20);
            this.baud_rateTextBox1.TabIndex = 5;
            // 
            // baud_rateLabel1
            // 
            baud_rateLabel1.AutoSize = true;
            baud_rateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            baud_rateLabel1.Location = new System.Drawing.Point(6, 136);
            baud_rateLabel1.Name = "baud_rateLabel1";
            baud_rateLabel1.Size = new System.Drawing.Size(56, 13);
            baud_rateLabel1.TabIndex = 4;
            baud_rateLabel1.Text = "Baud rate:";
            // 
            // deviceNameTextBox1
            // 
            this.deviceNameTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNameTextBox1.Location = new System.Drawing.Point(104, 107);
            this.deviceNameTextBox1.Name = "deviceNameTextBox1";
            this.deviceNameTextBox1.Size = new System.Drawing.Size(95, 20);
            this.deviceNameTextBox1.TabIndex = 3;
            this.deviceNameTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deviceNameTextBox1_KeyPress);
            // 
            // deviceNameLabel1
            // 
            deviceNameLabel1.AutoSize = true;
            deviceNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deviceNameLabel1.Location = new System.Drawing.Point(6, 110);
            deviceNameLabel1.Name = "deviceNameLabel1";
            deviceNameLabel1.Size = new System.Drawing.Size(75, 13);
            deviceNameLabel1.TabIndex = 2;
            deviceNameLabel1.Text = "Device Name:";
            // 
            // dAU_IDTextBox1
            // 
            this.dAU_IDTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dAU_IDTextBox1.Location = new System.Drawing.Point(104, 81);
            this.dAU_IDTextBox1.Name = "dAU_IDTextBox1";
            this.dAU_IDTextBox1.Size = new System.Drawing.Size(95, 20);
            this.dAU_IDTextBox1.TabIndex = 1;
            this.dAU_IDTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dAU_IDTextBox1_KeyPress);
            // 
            // dAU_IDLabel1
            // 
            dAU_IDLabel1.AutoSize = true;
            dAU_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dAU_IDLabel1.Location = new System.Drawing.Point(6, 84);
            dAU_IDLabel1.Name = "dAU_IDLabel1";
            dAU_IDLabel1.Size = new System.Drawing.Size(47, 13);
            dAU_IDLabel1.TabIndex = 0;
            dAU_IDLabel1.Text = "DAU ID:";
            // 
            // cbRDCdau
            // 
            this.cbRDCdau.DataSource = this.rDCBindingSource;
            this.cbRDCdau.DisplayMember = "Computer_ID";
            this.cbRDCdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRDCdau.FormattingEnabled = true;
            this.cbRDCdau.Location = new System.Drawing.Point(104, 238);
            this.cbRDCdau.Name = "cbRDCdau";
            this.cbRDCdau.Size = new System.Drawing.Size(95, 21);
            this.cbRDCdau.TabIndex = 21;
            this.cbRDCdau.ValueMember = "Computer_ID";
            this.cbRDCdau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbRDCdau_KeyPress);
            // 
            // cbModelDAU
            // 
            this.cbModelDAU.DataSource = this.tYPEBindingSource2;
            this.cbModelDAU.DisplayMember = "ModelName";
            this.cbModelDAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelDAU.FormattingEnabled = true;
            this.cbModelDAU.Location = new System.Drawing.Point(104, 263);
            this.cbModelDAU.Name = "cbModelDAU";
            this.cbModelDAU.Size = new System.Drawing.Size(95, 21);
            this.cbModelDAU.TabIndex = 22;
            this.cbModelDAU.ValueMember = "ModelNumber";
            this.cbModelDAU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbModelDAU_KeyPress);
            // 
            // cbCompanyDAU
            // 
            this.cbCompanyDAU.DataSource = this.cOMPANYBindingSource2;
            this.cbCompanyDAU.DisplayMember = "CompanyName";
            this.cbCompanyDAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompanyDAU.FormattingEnabled = true;
            this.cbCompanyDAU.Location = new System.Drawing.Point(104, 290);
            this.cbCompanyDAU.Name = "cbCompanyDAU";
            this.cbCompanyDAU.Size = new System.Drawing.Size(95, 21);
            this.cbCompanyDAU.TabIndex = 23;
            this.cbCompanyDAU.ValueMember = "CompanyID";
            this.cbCompanyDAU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCompanyDAU_KeyPress);
            // 
            // cbLocationDAU
            // 
            this.cbLocationDAU.DataSource = this.areaBindingSource2;
            this.cbLocationDAU.DisplayMember = "Location";
            this.cbLocationDAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocationDAU.FormattingEnabled = true;
            this.cbLocationDAU.Location = new System.Drawing.Point(104, 316);
            this.cbLocationDAU.Name = "cbLocationDAU";
            this.cbLocationDAU.Size = new System.Drawing.Size(95, 21);
            this.cbLocationDAU.TabIndex = 24;
            this.cbLocationDAU.ValueMember = "AreaID";
            this.cbLocationDAU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLocationDAU_KeyPress);
            // 
            // tabPage_serialPortConfig
            // 
            this.tabPage_serialPortConfig.AutoScroll = true;
            this.tabPage_serialPortConfig.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_serialPortConfig.Controls.Add(this.button_about);
            this.tabPage_serialPortConfig.Controls.Add(this.groupBox_selectPortAndBaud);
            this.tabPage_serialPortConfig.Controls.Add(this.toolStrip1);
            this.tabPage_serialPortConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPage_serialPortConfig.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage_serialPortConfig.Name = "tabPage_serialPortConfig";
            this.tabPage_serialPortConfig.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage_serialPortConfig.Size = new System.Drawing.Size(800, 474);
            this.tabPage_serialPortConfig.TabIndex = 0;
            this.tabPage_serialPortConfig.Text = "1. Ports";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_com,
            this.toolStripLabel_connected,
            this.toolStripLabel_disconnected});
            this.toolStrip1.Location = new System.Drawing.Point(1, 448);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "ToolTip";
            // 
            // toolStripLabel_com
            // 
            this.toolStripLabel_com.Name = "toolStripLabel_com";
            this.toolStripLabel_com.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel_com.Text = "ToolTip";
            // 
            // toolStripLabel_connected
            // 
            this.toolStripLabel_connected.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_connected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_connected.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripLabel_connected.Name = "toolStripLabel_connected";
            this.toolStripLabel_connected.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel_connected.Text = "Connected";
            this.toolStripLabel_connected.Visible = false;
            // 
            // toolStripLabel_disconnected
            // 
            this.toolStripLabel_disconnected.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_disconnected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_disconnected.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel_disconnected.Name = "toolStripLabel_disconnected";
            this.toolStripLabel_disconnected.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel_disconnected.Text = "Disconnected";
            this.toolStripLabel_disconnected.Visible = false;
            // 
            // groupBox_selectPortAndBaud
            // 
            this.groupBox_selectPortAndBaud.Controls.Add(this.comboBox_ports);
            this.groupBox_selectPortAndBaud.Controls.Add(this.labelComPorts);
            this.groupBox_selectPortAndBaud.Controls.Add(this.labelBaudRate);
            this.groupBox_selectPortAndBaud.Controls.Add(this.comboBox_baudRate);
            this.groupBox_selectPortAndBaud.Controls.Add(this.buttonDisconnect);
            this.groupBox_selectPortAndBaud.Controls.Add(this.buttonConnect);
            this.groupBox_selectPortAndBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_selectPortAndBaud.Location = new System.Drawing.Point(220, 116);
            this.groupBox_selectPortAndBaud.Name = "groupBox_selectPortAndBaud";
            this.groupBox_selectPortAndBaud.Size = new System.Drawing.Size(310, 161);
            this.groupBox_selectPortAndBaud.TabIndex = 13;
            this.groupBox_selectPortAndBaud.TabStop = false;
            this.groupBox_selectPortAndBaud.Text = "Connect to device";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(89, 96);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(1);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(109, 22);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            this.buttonConnect.MouseLeave += new System.EventHandler(this.buttonConnect_MouseLeave);
            this.buttonConnect.MouseHover += new System.EventHandler(this.buttonConnect_MouseHover);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(89, 125);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(109, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            this.buttonDisconnect.MouseLeave += new System.EventHandler(this.buttonDisconnect_MouseLeave);
            this.buttonDisconnect.MouseHover += new System.EventHandler(this.buttonDisconnect_MouseHover);
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(89, 49);
            this.comboBox_baudRate.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(112, 23);
            this.comboBox_baudRate.TabIndex = 1;
            this.comboBox_baudRate.MouseLeave += new System.EventHandler(this.comboBoxBitRates_MouseLeave);
            this.comboBox_baudRate.MouseHover += new System.EventHandler(this.comboBoxBitRates_MouseHover);
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaudRate.Location = new System.Drawing.Point(19, 50);
            this.labelBaudRate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(60, 15);
            this.labelBaudRate.TabIndex = 3;
            this.labelBaudRate.Text = "Baud rate";
            // 
            // labelComPorts
            // 
            this.labelComPorts.AutoSize = true;
            this.labelComPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComPorts.Location = new System.Drawing.Point(19, 25);
            this.labelComPorts.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelComPorts.Name = "labelComPorts";
            this.labelComPorts.Size = new System.Drawing.Size(70, 15);
            this.labelComPorts.TabIndex = 2;
            this.labelComPorts.Text = "Serial Ports";
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(89, 23);
            this.comboBox_ports.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(112, 23);
            this.comboBox_ports.Sorted = true;
            this.comboBox_ports.TabIndex = 0;
            this.comboBox_ports.Enter += new System.EventHandler(this.comboBoxComPorts_Enter);
            this.comboBox_ports.MouseLeave += new System.EventHandler(this.comboBoxComPorts_MouseLeave);
            this.comboBox_ports.MouseHover += new System.EventHandler(this.comboBoxComPorts_MouseHover);
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(476, 281);
            this.button_about.Margin = new System.Windows.Forms.Padding(1);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(55, 21);
            this.button_about.TabIndex = 4;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            this.button_about.MouseLeave += new System.EventHandler(this.button_about_MouseLeave);
            this.button_about.MouseHover += new System.EventHandler(this.button_about_MouseHover);
            // 
            // tabControl_DAU
            // 
            this.tabControl_DAU.Controls.Add(this.tabPage_serialPortConfig);
            this.tabControl_DAU.Controls.Add(this.tabPage_DAU);
            this.tabControl_DAU.Controls.Add(this.tabPage_instrumentConfig);
            this.tabControl_DAU.Controls.Add(this.tabPage_currentValues);
            this.tabControl_DAU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_DAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_DAU.Location = new System.Drawing.Point(0, 0);
            this.tabControl_DAU.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl_DAU.MinimumSize = new System.Drawing.Size(771, 489);
            this.tabControl_DAU.Name = "tabControl_DAU";
            this.tabControl_DAU.SelectedIndex = 0;
            this.tabControl_DAU.Size = new System.Drawing.Size(808, 500);
            this.tabControl_DAU.TabIndex = 5;
            this.tabControl_DAU.TabStop = false;
            // 
            // FormMainSoftSense
            // 
            this.AcceptButton = this.button_read;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(808, 500);
            this.Controls.Add(this.tabControl_DAU);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(824, 539);
            this.Name = "FormMainSoftSense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSenseConf";
            this.Load += new System.EventHandler(this.FormMainSoftSense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensConfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENT1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDC1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAU1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource1)).EndInit();
            this.tabPage_currentValues.ResumeLayout(false);
            this.tabPage_currentValues.PerformLayout();
            this.toolStrip_currentValues.ResumeLayout(false);
            this.toolStrip_currentValues.PerformLayout();
            this.groupBox_rawValues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_rawValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_scaledLive)).EndInit();
            this.groupBox_liveData.ResumeLayout(false);
            this.groupBox_scaledValues.ResumeLayout(false);
            this.tabPage_instrumentConfig.ResumeLayout(false);
            this.tabPage_instrumentConfig.PerformLayout();
            this.toolStrip_instrumentConf.ResumeLayout(false);
            this.toolStrip_instrumentConf.PerformLayout();
            this.groupBox_values.ResumeLayout(false);
            this.groupBox_values.PerformLayout();
            this.gbFilterInstrument.ResumeLayout(false);
            this.gbFilterInstrument.PerformLayout();
            this.groupBox_configData.ResumeLayout(false);
            this.groupBox_configData.PerformLayout();
            this.tabPage_DAU.ResumeLayout(false);
            this.tabPage_DAU.PerformLayout();
            this.toolStrip_InputOutput.ResumeLayout(false);
            this.toolStrip_InputOutput.PerformLayout();
            this.groupBox_DAUFiltering.ResumeLayout(false);
            this.groupBox_DAUFiltering.PerformLayout();
            this.groupBoxDAURegUpd.ResumeLayout(false);
            this.groupBoxDAURegUpd.PerformLayout();
            this.tabPage_serialPortConfig.ResumeLayout(false);
            this.tabPage_serialPortConfig.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox_selectPortAndBaud.ResumeLayout(false);
            this.groupBox_selectPortAndBaud.PerformLayout();
            this.tabControl_DAU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort_ComPorts;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_saveConfigurations;
        private System.Windows.Forms.Timer timer_configurations;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_instrumentConfig;
        private System.Windows.Forms.Timer timer_write;
        private System.Windows.Forms.Timer timer_rawValuesLive;
        private System.Windows.Forms.Timer timer_rawValuesLive2;
        private System.Windows.Forms.Timer timer_scaledLive1;
        private System.Windows.Forms.Timer timer_scaledLive2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_currentValues;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_chartRaw;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_chartScaled;
        private SoftSensConfDataSet softSensConfDataSet;
        private System.Windows.Forms.BindingSource dAUBindingSource;
        private SoftSensConfDataSetTableAdapters.DAUTableAdapter dAUTableAdapter;
        private SoftSensConfDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SoftSensConfDataSetTableAdapters.TYPETableAdapter tYPETableAdapter;
        private System.Windows.Forms.BindingSource tYPEBindingSource;
        private SoftSensConfDataSetTableAdapters.COMPANYTableAdapter cOMPANYTableAdapter;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource;
        private SoftSensConfDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private SoftSensConfDataSetTableAdapters.DAU1TableAdapter dAU1TableAdapter;
        private System.Windows.Forms.BindingSource dAU1BindingSource;
        private System.Windows.Forms.BindingSource areaBindingSource1;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource1;
        private System.Windows.Forms.BindingSource tYPEBindingSource1;
        private System.Windows.Forms.BindingSource rDCBindingSource;
        private SoftSensConfDataSetTableAdapters.RDCTableAdapter rDCTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource2;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource2;
        private System.Windows.Forms.BindingSource tYPEBindingSource2;
        private System.Windows.Forms.BindingSource iNSTRUMENT1BindingSource;
        private SoftSensConfDataSetTableAdapters.INSTRUMENT1TableAdapter iNSTRUMENT1TableAdapter;
        private System.Windows.Forms.BindingSource iNSTRUMENTBindingSource;
        private SoftSensConfDataSetTableAdapters.INSTRUMENTTableAdapter iNSTRUMENTTableAdapter;
        private System.Windows.Forms.BindingSource rDC1BindingSource;
        private SoftSensConfDataSetTableAdapters.RDC1TableAdapter rDC1TableAdapter;
        private System.Windows.Forms.BindingSource mCUBindingSource;
        private SoftSensConfDataSetTableAdapters.MCUTableAdapter mCUTableAdapter;
        private System.Windows.Forms.TabPage tabPage_currentValues;
        private System.Windows.Forms.Label labelStandardInterval;
        private System.Windows.Forms.Label labelloggingInterval;
        private System.Windows.Forms.Label label_sentToDatabase;
        private System.Windows.Forms.GroupBox groupBox_scaledValues;
        private System.Windows.Forms.ListBox listBox_liveDataScaled;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_stopLive;
        private System.Windows.Forms.Button button_status2;
        private System.Windows.Forms.CheckBox checkBox_scaled;
        private System.Windows.Forms.Button button_saveChart;
        private System.Windows.Forms.Button button_startLiveValues;
        private System.Windows.Forms.CheckBox checkBox_raw;
        private System.Windows.Forms.Button button_resetCurrentValues;
        private System.Windows.Forms.Button button_saveCurrentValues;
        private System.Windows.Forms.GroupBox groupBox_liveData;
        private System.Windows.Forms.ListBox listBox_liveDataRaw;
        private System.Windows.Forms.GroupBox groupBox_rawValues;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_scaledLive;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_rawValues;
        private System.Windows.Forms.ToolStrip toolStrip_currentValues;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_currentValues;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3_disconnected;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3_connected;
        private System.Windows.Forms.TabPage tabPage_instrumentConfig;
        private System.Windows.Forms.GroupBox groupBox_configData;
        private System.Windows.Forms.TextBox textBox_showConfigurations;
        private System.Windows.Forms.Button button_loadValue;
        private System.Windows.Forms.Button button_saveConfigurations;
        private System.Windows.Forms.Button button_raw;
        private System.Windows.Forms.Button button_scaled;
        private System.Windows.Forms.GroupBox gbFilterInstrument;
        private System.Windows.Forms.TextBox tagNameTextBox;
        private System.Windows.Forms.TextBox loweRangeValuesTextBox;
        private System.Windows.Forms.TextBox upperRangeValuesTextBox;
        private System.Windows.Forms.TextBox alarmLowTextBox;
        private System.Windows.Forms.TextBox alarmHighTextBox;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.TextBox measurementUnitTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox2;
        private System.Windows.Forms.TextBox dAU_IDTextBox2;
        private System.Windows.Forms.TextBox modelNumberTextBox;
        private System.Windows.Forms.TextBox companyIDTextBox;
        private System.Windows.Forms.TextBox areaIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFindInstrument;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.GroupBox groupBox_values;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_DatabaseConfig;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox comboBox_DAU_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tagName;
        private System.Windows.Forms.TextBox textBox_tagName;
        private System.Windows.Forms.TextBox textBox_alarmLow;
        private System.Windows.Forms.Button button_status;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.TextBox textBox_upperRangeValue;
        private System.Windows.Forms.TextBox textBox_lowerRangeValue;
        private System.Windows.Forms.TextBox textBox_alarmHigh;
        private System.Windows.Forms.Label label_LRV;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Label label_alarmHigh;
        private System.Windows.Forms.Label label_URV;
        private System.Windows.Forms.Label label_alarmLow;
        private System.Windows.Forms.ToolStrip toolStrip_instrumentConf;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_instrumentConfig;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2_disconnected;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2_connected;
        private System.Windows.Forms.TabPage tabPage_DAU;
        private System.Windows.Forms.GroupBox groupBoxDAURegUpd;
        private System.Windows.Forms.ComboBox cbLocationDAU;
        private System.Windows.Forms.ComboBox cbCompanyDAU;
        private System.Windows.Forms.ComboBox cbModelDAU;
        private System.Windows.Forms.ComboBox cbRDCdau;
        private System.Windows.Forms.TextBox dAU_IDTextBox1;
        private System.Windows.Forms.TextBox deviceNameTextBox1;
        private System.Windows.Forms.TextBox baud_rateTextBox1;
        private System.Windows.Forms.TextBox data_bitsTextBox1;
        private System.Windows.Forms.TextBox parityTextBox1;
        private System.Windows.Forms.TextBox stop_bitTextBox1;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private System.Windows.Forms.Button btnClearDAU;
        private System.Windows.Forms.Button btnUpdateDAU;
        private System.Windows.Forms.GroupBox groupBox_DAUFiltering;
        private System.Windows.Forms.TextBox computer_IDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.ComboBox cbFindDeviceDAU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dAU_IDTextBox;
        private System.Windows.Forms.TextBox deviceNameTextBox;
        private System.Windows.Forms.TextBox baud_rateTextBox;
        private System.Windows.Forms.TextBox data_bitsTextBox;
        private System.Windows.Forms.TextBox parityTextBox;
        private System.Windows.Forms.TextBox stop_bitTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ToolStrip toolStrip_InputOutput;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4_disconnected;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4_connected;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDAU;
        private System.Windows.Forms.TabPage tabPage_serialPortConfig;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.GroupBox groupBox_selectPortAndBaud;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.Label labelComPorts;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_com;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_connected;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_disconnected;
        private System.Windows.Forms.TabControl tabControl_DAU;
    }
}

