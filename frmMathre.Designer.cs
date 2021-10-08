using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Mathre
{
    [DesignerGenerated()]
    public partial class FrmMathre : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMathre));
            this.mnuBaseLayer = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSecret = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecolor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTechnicolor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRandomify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMySchool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMySchoolToggleMascot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangleCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteActor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteFruit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteHobby = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemperature = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemperatureFahrenheit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemperatureCelsius = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDigits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDigitsCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewHelloWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewMySchool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewMyFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewTemperature = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewDigits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewUnknown = new System.Windows.Forms.ToolStripMenuItem();
            this.imgFavoriteImages = new System.Windows.Forms.ImageList(this.components);
            this.tabUnknown = new System.Windows.Forms.TabPage();
            this.tabSecret = new System.Windows.Forms.TabPage();
            this.lblSecretTitle = new System.Windows.Forms.Label();
            this.grpSecret = new Mathre.CustomGroupBox();
            this.btnSecretDisable = new System.Windows.Forms.RadioButton();
            this.btnSecretEnable = new System.Windows.Forms.RadioButton();
            this.txtSecretPassword = new System.Windows.Forms.TextBox();
            this.lblSecretPrompt = new System.Windows.Forms.Label();
            this.tabMyFavorites = new System.Windows.Forms.TabPage();
            this.grpFavoriteControls = new Mathre.CustomGroupBox();
            this.btnFavoriteMovie = new System.Windows.Forms.RadioButton();
            this.btnFavoriteColor = new System.Windows.Forms.RadioButton();
            this.btnFavoriteFruit = new System.Windows.Forms.RadioButton();
            this.btnFavoriteActor = new System.Windows.Forms.RadioButton();
            this.btnFavoriteHobby = new System.Windows.Forms.RadioButton();
            this.grpFavoriteDisplay = new Mathre.CustomGroupBox();
            this.grpFavoriteImage = new Mathre.CustomGroupBox();
            this.lblFavoriteInfo = new System.Windows.Forms.Label();
            this.lblFavoriteTitle = new System.Windows.Forms.Label();
            this.tabRectangle = new System.Windows.Forms.TabPage();
            this.grpRectangleContainer = new Mathre.CustomGroupBox();
            this.lblRectangleError = new System.Windows.Forms.Label();
            this.grpRectangle = new Mathre.CustomGroupBox();
            this.lblRectangleTitle = new System.Windows.Forms.Label();
            this.grpRectangleControls = new Mathre.CustomGroupBox();
            this.btnRectangleCalculate = new System.Windows.Forms.Button();
            this.lblRectangleAreaTitle = new System.Windows.Forms.Label();
            this.txtRectangleDimensions = new System.Windows.Forms.TextBox();
            this.lblRectangleDimensions = new System.Windows.Forms.Label();
            this.lblRectanglePerimiterTitle = new System.Windows.Forms.Label();
            this.lblRectangleArea = new System.Windows.Forms.Label();
            this.lblRectanglePerimeter = new System.Windows.Forms.Label();
            this.tabMySchool = new System.Windows.Forms.TabPage();
            this.lblMySchoolTitle = new System.Windows.Forms.Label();
            this.grpMySchool = new Mathre.CustomGroupBox();
            this.lblMySchoolMascot = new System.Windows.Forms.Label();
            this.picMySchoolMascot = new System.Windows.Forms.PictureBox();
            this.btnMySchoolToggleMascot = new System.Windows.Forms.Button();
            this.tabHelloWorld = new System.Windows.Forms.TabPage();
            this.grpHelloWorld = new Mathre.CustomGroupBox();
            this.picHelloWorldGerman = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldFrench = new System.Windows.Forms.RadioButton();
            this.picHelloWorldEnglish = new System.Windows.Forms.PictureBox();
            this.picHelloWorldFrench = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldReset = new System.Windows.Forms.Button();
            this.btnHelloWorldGerman = new System.Windows.Forms.RadioButton();
            this.btnHelloWorldEnglish = new System.Windows.Forms.RadioButton();
            this.lblHelloWorldTitle = new System.Windows.Forms.Label();
            this.tabMathre = new System.Windows.Forms.TabControl();
            this.tabTemperature = new System.Windows.Forms.TabPage();
            this.grpTemperatureResults = new Mathre.CustomGroupBox();
            this.lblCelsiusDisplay = new System.Windows.Forms.Label();
            this.lblFahrenheitDisplay = new System.Windows.Forms.Label();
            this.lblCelsiusDisplayLabel = new System.Windows.Forms.Label();
            this.lblFahrenheitDisplayLabel = new System.Windows.Forms.Label();
            this.lblTemperatureTitle = new System.Windows.Forms.Label();
            this.grpTemperature = new Mathre.CustomGroupBox();
            this.btnCelsius = new System.Windows.Forms.RadioButton();
            this.btnFahrenheit = new System.Windows.Forms.RadioButton();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.tabDigits = new System.Windows.Forms.TabPage();
            this.grpDigitsResults = new Mathre.CustomGroupBox();
            this.pnlDigitsResults = new System.Windows.Forms.Panel();
            this.lblDigitsResultsLabel = new System.Windows.Forms.Label();
            this.lblDigitsListOdds = new System.Windows.Forms.Label();
            this.lblDigitsListEvens = new System.Windows.Forms.Label();
            this.lblDigitsTitle = new System.Windows.Forms.Label();
            this.grpDigits = new Mathre.CustomGroupBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblDigits = new System.Windows.Forms.Label();
            this.lblDigitsCount = new System.Windows.Forms.Label();
            this.lblDigitsCountLabel = new System.Windows.Forms.Label();
            this.tabChangeMaker = new System.Windows.Forms.TabPage();
            this.customGroupBox1 = new Mathre.CustomGroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customGroupBox2 = new Mathre.CustomGroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPizza = new System.Windows.Forms.TabPage();
            this.customGroupBox5 = new Mathre.CustomGroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.customGroupBox3 = new Mathre.CustomGroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mnuBaseLayer.SuspendLayout();
            this.tabSecret.SuspendLayout();
            this.grpSecret.SuspendLayout();
            this.tabMyFavorites.SuspendLayout();
            this.grpFavoriteControls.SuspendLayout();
            this.grpFavoriteDisplay.SuspendLayout();
            this.tabRectangle.SuspendLayout();
            this.grpRectangleContainer.SuspendLayout();
            this.grpRectangleControls.SuspendLayout();
            this.tabMySchool.SuspendLayout();
            this.grpMySchool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).BeginInit();
            this.tabHelloWorld.SuspendLayout();
            this.grpHelloWorld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldGerman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldFrench)).BeginInit();
            this.tabMathre.SuspendLayout();
            this.tabTemperature.SuspendLayout();
            this.grpTemperatureResults.SuspendLayout();
            this.grpTemperature.SuspendLayout();
            this.tabDigits.SuspendLayout();
            this.grpDigitsResults.SuspendLayout();
            this.pnlDigitsResults.SuspendLayout();
            this.grpDigits.SuspendLayout();
            this.tabChangeMaker.SuspendLayout();
            this.customGroupBox1.SuspendLayout();
            this.customGroupBox2.SuspendLayout();
            this.tabPizza.SuspendLayout();
            this.customGroupBox5.SuspendLayout();
            this.customGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBaseLayer
            // 
            this.mnuBaseLayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuBaseLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView});
            this.mnuBaseLayer.Location = new System.Drawing.Point(0, 0);
            this.mnuBaseLayer.Name = "mnuBaseLayer";
            this.mnuBaseLayer.Padding = new System.Windows.Forms.Padding(0);
            this.mnuBaseLayer.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuBaseLayer.Size = new System.Drawing.Size(1047, 24);
            this.mnuBaseLayer.TabIndex = 0;
            this.mnuBaseLayer.Text = "Menu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSecret,
            this.mnuHelloWorld,
            this.mnuMySchool,
            this.mnuRectangle,
            this.mnuFavorites,
            this.mnuTemperature,
            this.mnuDigits,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuSecret
            // 
            this.mnuSecret.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecolor,
            this.mnuRandomify});
            this.mnuSecret.Enabled = false;
            this.mnuSecret.Name = "mnuSecret";
            this.mnuSecret.Size = new System.Drawing.Size(195, 22);
            this.mnuSecret.Text = "Super Secret Settings";
            // 
            // mnuRecolor
            // 
            this.mnuRecolor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDarkMode,
            this.mnuTechnicolor});
            this.mnuRecolor.Enabled = false;
            this.mnuRecolor.Name = "mnuRecolor";
            this.mnuRecolor.Size = new System.Drawing.Size(132, 22);
            this.mnuRecolor.Text = "Recolor";
            // 
            // mnuDarkMode
            // 
            this.mnuDarkMode.Enabled = false;
            this.mnuDarkMode.Name = "mnuDarkMode";
            this.mnuDarkMode.Size = new System.Drawing.Size(135, 22);
            this.mnuDarkMode.Text = "Dark Mode";
            // 
            // mnuTechnicolor
            // 
            this.mnuTechnicolor.Enabled = false;
            this.mnuTechnicolor.Name = "mnuTechnicolor";
            this.mnuTechnicolor.Size = new System.Drawing.Size(135, 22);
            this.mnuTechnicolor.Text = "Technicolor";
            // 
            // mnuRandomify
            // 
            this.mnuRandomify.Name = "mnuRandomify";
            this.mnuRandomify.Size = new System.Drawing.Size(132, 22);
            this.mnuRandomify.Text = "Randomify";
            // 
            // mnuHelloWorld
            // 
            this.mnuHelloWorld.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelloWorldLanguage,
            this.mnuHelloWorldReset});
            this.mnuHelloWorld.Name = "mnuHelloWorld";
            this.mnuHelloWorld.Size = new System.Drawing.Size(195, 22);
            this.mnuHelloWorld.Text = "Hello World";
            // 
            // mnuHelloWorldLanguage
            // 
            this.mnuHelloWorldLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelloWorldLanguageEnglish,
            this.mnuHelloWorldLanguageFrench,
            this.mnuHelloWorldLanguageGerman});
            this.mnuHelloWorldLanguage.Name = "mnuHelloWorldLanguage";
            this.mnuHelloWorldLanguage.Size = new System.Drawing.Size(126, 22);
            this.mnuHelloWorldLanguage.Text = "Language";
            // 
            // mnuHelloWorldLanguageEnglish
            // 
            this.mnuHelloWorldLanguageEnglish.Image = global::Mathre.My.Resources.Resources.EnglishAtScale;
            this.mnuHelloWorldLanguageEnglish.Name = "mnuHelloWorldLanguageEnglish";
            this.mnuHelloWorldLanguageEnglish.Size = new System.Drawing.Size(116, 22);
            this.mnuHelloWorldLanguageEnglish.Text = "English";
            // 
            // mnuHelloWorldLanguageFrench
            // 
            this.mnuHelloWorldLanguageFrench.Image = global::Mathre.My.Resources.Resources.French;
            this.mnuHelloWorldLanguageFrench.Name = "mnuHelloWorldLanguageFrench";
            this.mnuHelloWorldLanguageFrench.Size = new System.Drawing.Size(116, 22);
            this.mnuHelloWorldLanguageFrench.Text = "French";
            // 
            // mnuHelloWorldLanguageGerman
            // 
            this.mnuHelloWorldLanguageGerman.Image = global::Mathre.My.Resources.Resources.German;
            this.mnuHelloWorldLanguageGerman.Name = "mnuHelloWorldLanguageGerman";
            this.mnuHelloWorldLanguageGerman.Size = new System.Drawing.Size(116, 22);
            this.mnuHelloWorldLanguageGerman.Text = "German";
            // 
            // mnuHelloWorldReset
            // 
            this.mnuHelloWorldReset.Name = "mnuHelloWorldReset";
            this.mnuHelloWorldReset.Size = new System.Drawing.Size(126, 22);
            this.mnuHelloWorldReset.Text = "Reset";
            // 
            // mnuMySchool
            // 
            this.mnuMySchool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMySchoolToggleMascot});
            this.mnuMySchool.Name = "mnuMySchool";
            this.mnuMySchool.Size = new System.Drawing.Size(195, 22);
            this.mnuMySchool.Text = "My School";
            // 
            // mnuMySchoolToggleMascot
            // 
            this.mnuMySchoolToggleMascot.Name = "mnuMySchoolToggleMascot";
            this.mnuMySchoolToggleMascot.Size = new System.Drawing.Size(198, 22);
            this.mnuMySchoolToggleMascot.Text = "Toggle Mascot Visibility";
            // 
            // mnuRectangle
            // 
            this.mnuRectangle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRectangleCalculate});
            this.mnuRectangle.Name = "mnuRectangle";
            this.mnuRectangle.Size = new System.Drawing.Size(195, 22);
            this.mnuRectangle.Text = "Rectangle Calculator";
            // 
            // mnuRectangleCalculate
            // 
            this.mnuRectangleCalculate.Name = "mnuRectangleCalculate";
            this.mnuRectangleCalculate.Size = new System.Drawing.Size(123, 22);
            this.mnuRectangleCalculate.Text = "Calculate";
            // 
            // mnuFavorites
            // 
            this.mnuFavorites.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFavoriteActor,
            this.mnuFavoriteMovie,
            this.mnuFavoriteFruit,
            this.mnuFavoriteColor,
            this.mnuFavoriteHobby});
            this.mnuFavorites.Name = "mnuFavorites";
            this.mnuFavorites.Size = new System.Drawing.Size(195, 22);
            this.mnuFavorites.Text = "My Favorites";
            // 
            // mnuFavoriteActor
            // 
            this.mnuFavoriteActor.Name = "mnuFavoriteActor";
            this.mnuFavoriteActor.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteActor.Text = "Actor";
            // 
            // mnuFavoriteMovie
            // 
            this.mnuFavoriteMovie.Name = "mnuFavoriteMovie";
            this.mnuFavoriteMovie.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteMovie.Text = "Movie";
            // 
            // mnuFavoriteFruit
            // 
            this.mnuFavoriteFruit.Name = "mnuFavoriteFruit";
            this.mnuFavoriteFruit.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteFruit.Text = "Fruit";
            // 
            // mnuFavoriteColor
            // 
            this.mnuFavoriteColor.Name = "mnuFavoriteColor";
            this.mnuFavoriteColor.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteColor.Text = "Color";
            // 
            // mnuFavoriteHobby
            // 
            this.mnuFavoriteHobby.Name = "mnuFavoriteHobby";
            this.mnuFavoriteHobby.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteHobby.Text = "Hobby";
            // 
            // mnuTemperature
            // 
            this.mnuTemperature.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTemperatureFahrenheit,
            this.mnuTemperatureCelsius});
            this.mnuTemperature.Name = "mnuTemperature";
            this.mnuTemperature.Size = new System.Drawing.Size(195, 22);
            this.mnuTemperature.Text = "Temperature Converter";
            // 
            // mnuTemperatureFahrenheit
            // 
            this.mnuTemperatureFahrenheit.Name = "mnuTemperatureFahrenheit";
            this.mnuTemperatureFahrenheit.Size = new System.Drawing.Size(130, 22);
            this.mnuTemperatureFahrenheit.Text = "Fahrenheit";
            // 
            // mnuTemperatureCelsius
            // 
            this.mnuTemperatureCelsius.Name = "mnuTemperatureCelsius";
            this.mnuTemperatureCelsius.Size = new System.Drawing.Size(130, 22);
            this.mnuTemperatureCelsius.Text = "Celsius";
            // 
            // mnuDigits
            // 
            this.mnuDigits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDigitsCalculate});
            this.mnuDigits.Name = "mnuDigits";
            this.mnuDigits.Size = new System.Drawing.Size(195, 22);
            this.mnuDigits.Text = "Digit Separator";
            // 
            // mnuDigitsCalculate
            // 
            this.mnuDigitsCalculate.Name = "mnuDigitsCalculate";
            this.mnuDigitsCalculate.Size = new System.Drawing.Size(123, 22);
            this.mnuDigitsCalculate.Text = "Calculate";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(195, 22);
            this.mnuExit.Text = "Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 24);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewHelloWorld,
            this.mnuViewMySchool,
            this.mnuViewRectangle,
            this.mnuViewMyFavorites,
            this.mnuViewTemperature,
            this.mnuViewDigits,
            this.mnuViewUnknown});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 24);
            this.mnuView.Text = "View";
            // 
            // mnuViewHelloWorld
            // 
            this.mnuViewHelloWorld.Name = "mnuViewHelloWorld";
            this.mnuViewHelloWorld.Size = new System.Drawing.Size(195, 22);
            this.mnuViewHelloWorld.Text = "Hello World";
            // 
            // mnuViewMySchool
            // 
            this.mnuViewMySchool.Name = "mnuViewMySchool";
            this.mnuViewMySchool.Size = new System.Drawing.Size(195, 22);
            this.mnuViewMySchool.Text = "My School";
            // 
            // mnuViewRectangle
            // 
            this.mnuViewRectangle.Name = "mnuViewRectangle";
            this.mnuViewRectangle.Size = new System.Drawing.Size(195, 22);
            this.mnuViewRectangle.Text = "Rectangle Calculator";
            // 
            // mnuViewMyFavorites
            // 
            this.mnuViewMyFavorites.Name = "mnuViewMyFavorites";
            this.mnuViewMyFavorites.Size = new System.Drawing.Size(195, 22);
            this.mnuViewMyFavorites.Text = "My Favorites";
            // 
            // mnuViewTemperature
            // 
            this.mnuViewTemperature.Name = "mnuViewTemperature";
            this.mnuViewTemperature.Size = new System.Drawing.Size(195, 22);
            this.mnuViewTemperature.Text = "Temperature Converter";
            // 
            // mnuViewDigits
            // 
            this.mnuViewDigits.Name = "mnuViewDigits";
            this.mnuViewDigits.Size = new System.Drawing.Size(195, 22);
            this.mnuViewDigits.Text = "Digit Separator";
            // 
            // mnuViewUnknown
            // 
            this.mnuViewUnknown.Name = "mnuViewUnknown";
            this.mnuViewUnknown.Size = new System.Drawing.Size(195, 22);
            this.mnuViewUnknown.Text = "...";
            // 
            // imgFavoriteImages
            // 
            this.imgFavoriteImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFavoriteImages.ImageStream")));
            this.imgFavoriteImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFavoriteImages.Images.SetKeyName(0, "Actor.jpg");
            this.imgFavoriteImages.Images.SetKeyName(1, "Fruit.jpg");
            this.imgFavoriteImages.Images.SetKeyName(2, "Hobby.jpg");
            this.imgFavoriteImages.Images.SetKeyName(3, "Movie.jpg");
            // 
            // tabUnknown
            // 
            this.tabUnknown.Location = new System.Drawing.Point(4, 22);
            this.tabUnknown.Name = "tabUnknown";
            this.tabUnknown.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnknown.Size = new System.Drawing.Size(1044, 486);
            this.tabUnknown.TabIndex = 2;
            this.tabUnknown.Text = "...";
            this.tabUnknown.UseVisualStyleBackColor = true;
            // 
            // tabSecret
            // 
            this.tabSecret.Controls.Add(this.lblSecretTitle);
            this.tabSecret.Controls.Add(this.grpSecret);
            this.tabSecret.Location = new System.Drawing.Point(4, 22);
            this.tabSecret.Name = "tabSecret";
            this.tabSecret.Size = new System.Drawing.Size(1044, 486);
            this.tabSecret.TabIndex = 3;
            this.tabSecret.Text = "Secret Settings Page";
            this.tabSecret.UseVisualStyleBackColor = true;
            // 
            // lblSecretTitle
            // 
            this.lblSecretTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecretTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretTitle.Location = new System.Drawing.Point(209, 71);
            this.lblSecretTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblSecretTitle.Name = "lblSecretTitle";
            this.lblSecretTitle.Size = new System.Drawing.Size(626, 51);
            this.lblSecretTitle.TabIndex = 9;
            this.lblSecretTitle.Text = "Enable Super Secret Settings";
            this.lblSecretTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSecret
            // 
            this.grpSecret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpSecret.AutoSize = true;
            this.grpSecret.BackColor = System.Drawing.SystemColors.Control;
            this.grpSecret.BorderColor = System.Drawing.Color.Black;
            this.grpSecret.Controls.Add(this.btnSecretDisable);
            this.grpSecret.Controls.Add(this.btnSecretEnable);
            this.grpSecret.Controls.Add(this.txtSecretPassword);
            this.grpSecret.Controls.Add(this.lblSecretPrompt);
            this.grpSecret.Location = new System.Drawing.Point(309, 140);
            this.grpSecret.Name = "grpSecret";
            this.grpSecret.Size = new System.Drawing.Size(426, 105);
            this.grpSecret.TabIndex = 8;
            this.grpSecret.TabStop = false;
            // 
            // btnSecretDisable
            // 
            this.btnSecretDisable.AutoSize = true;
            this.btnSecretDisable.Checked = true;
            this.btnSecretDisable.Enabled = false;
            this.btnSecretDisable.Location = new System.Drawing.Point(85, 66);
            this.btnSecretDisable.Name = "btnSecretDisable";
            this.btnSecretDisable.Size = new System.Drawing.Size(60, 17);
            this.btnSecretDisable.TabIndex = 11;
            this.btnSecretDisable.TabStop = true;
            this.btnSecretDisable.Text = "Disable";
            this.btnSecretDisable.UseVisualStyleBackColor = true;
            // 
            // btnSecretEnable
            // 
            this.btnSecretEnable.AutoSize = true;
            this.btnSecretEnable.Enabled = false;
            this.btnSecretEnable.Location = new System.Drawing.Point(283, 67);
            this.btnSecretEnable.Name = "btnSecretEnable";
            this.btnSecretEnable.Size = new System.Drawing.Size(58, 17);
            this.btnSecretEnable.TabIndex = 10;
            this.btnSecretEnable.Text = "Enable";
            this.btnSecretEnable.UseVisualStyleBackColor = true;
            // 
            // txtSecretPassword
            // 
            this.txtSecretPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtSecretPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecretPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretPassword.Location = new System.Drawing.Point(261, 21);
            this.txtSecretPassword.Name = "txtSecretPassword";
            this.txtSecretPassword.PasswordChar = '∗';
            this.txtSecretPassword.Size = new System.Drawing.Size(114, 26);
            this.txtSecretPassword.TabIndex = 9;
            // 
            // lblSecretPrompt
            // 
            this.lblSecretPrompt.AutoSize = true;
            this.lblSecretPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretPrompt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSecretPrompt.Location = new System.Drawing.Point(52, 23);
            this.lblSecretPrompt.Name = "lblSecretPrompt";
            this.lblSecretPrompt.Size = new System.Drawing.Size(153, 20);
            this.lblSecretPrompt.TabIndex = 9;
            this.lblSecretPrompt.Text = "Enter the Passcode:";
            // 
            // tabMyFavorites
            // 
            this.tabMyFavorites.Controls.Add(this.grpFavoriteControls);
            this.tabMyFavorites.Controls.Add(this.grpFavoriteDisplay);
            this.tabMyFavorites.Controls.Add(this.lblFavoriteTitle);
            this.tabMyFavorites.Location = new System.Drawing.Point(4, 22);
            this.tabMyFavorites.Name = "tabMyFavorites";
            this.tabMyFavorites.Size = new System.Drawing.Size(1044, 486);
            this.tabMyFavorites.TabIndex = 5;
            this.tabMyFavorites.Text = "My Favorites";
            this.tabMyFavorites.UseVisualStyleBackColor = true;
            // 
            // grpFavoriteControls
            // 
            this.grpFavoriteControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpFavoriteControls.AutoSize = true;
            this.grpFavoriteControls.BackColor = System.Drawing.SystemColors.Control;
            this.grpFavoriteControls.BorderColor = System.Drawing.Color.Black;
            this.grpFavoriteControls.Controls.Add(this.btnFavoriteMovie);
            this.grpFavoriteControls.Controls.Add(this.btnFavoriteColor);
            this.grpFavoriteControls.Controls.Add(this.btnFavoriteFruit);
            this.grpFavoriteControls.Controls.Add(this.btnFavoriteActor);
            this.grpFavoriteControls.Controls.Add(this.btnFavoriteHobby);
            this.grpFavoriteControls.Location = new System.Drawing.Point(309, 140);
            this.grpFavoriteControls.Name = "grpFavoriteControls";
            this.grpFavoriteControls.Size = new System.Drawing.Size(426, 105);
            this.grpFavoriteControls.TabIndex = 19;
            this.grpFavoriteControls.TabStop = false;
            // 
            // btnFavoriteMovie
            // 
            this.btnFavoriteMovie.AutoSize = true;
            this.btnFavoriteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoriteMovie.Location = new System.Drawing.Point(102, 55);
            this.btnFavoriteMovie.Name = "btnFavoriteMovie";
            this.btnFavoriteMovie.Size = new System.Drawing.Size(68, 24);
            this.btnFavoriteMovie.TabIndex = 24;
            this.btnFavoriteMovie.Text = "Movie";
            this.btnFavoriteMovie.UseVisualStyleBackColor = true;
            // 
            // btnFavoriteColor
            // 
            this.btnFavoriteColor.AutoSize = true;
            this.btnFavoriteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoriteColor.Location = new System.Drawing.Point(334, 26);
            this.btnFavoriteColor.Name = "btnFavoriteColor";
            this.btnFavoriteColor.Size = new System.Drawing.Size(64, 24);
            this.btnFavoriteColor.TabIndex = 22;
            this.btnFavoriteColor.Text = "Color";
            this.btnFavoriteColor.UseVisualStyleBackColor = true;
            // 
            // btnFavoriteFruit
            // 
            this.btnFavoriteFruit.AutoSize = true;
            this.btnFavoriteFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoriteFruit.Location = new System.Drawing.Point(184, 26);
            this.btnFavoriteFruit.Name = "btnFavoriteFruit";
            this.btnFavoriteFruit.Size = new System.Drawing.Size(59, 24);
            this.btnFavoriteFruit.TabIndex = 23;
            this.btnFavoriteFruit.Text = "Fruit";
            this.btnFavoriteFruit.UseVisualStyleBackColor = true;
            // 
            // btnFavoriteActor
            // 
            this.btnFavoriteActor.AutoSize = true;
            this.btnFavoriteActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoriteActor.Location = new System.Drawing.Point(28, 26);
            this.btnFavoriteActor.Name = "btnFavoriteActor";
            this.btnFavoriteActor.Size = new System.Drawing.Size(65, 24);
            this.btnFavoriteActor.TabIndex = 20;
            this.btnFavoriteActor.Text = "Actor";
            this.btnFavoriteActor.UseVisualStyleBackColor = true;
            // 
            // btnFavoriteHobby
            // 
            this.btnFavoriteHobby.AutoSize = true;
            this.btnFavoriteHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoriteHobby.Location = new System.Drawing.Point(252, 55);
            this.btnFavoriteHobby.Name = "btnFavoriteHobby";
            this.btnFavoriteHobby.Size = new System.Drawing.Size(73, 24);
            this.btnFavoriteHobby.TabIndex = 21;
            this.btnFavoriteHobby.Text = "Hobby";
            this.btnFavoriteHobby.UseVisualStyleBackColor = true;
            // 
            // grpFavoriteDisplay
            // 
            this.grpFavoriteDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpFavoriteDisplay.BorderColor = System.Drawing.Color.Black;
            this.grpFavoriteDisplay.Controls.Add(this.grpFavoriteImage);
            this.grpFavoriteDisplay.Controls.Add(this.lblFavoriteInfo);
            this.grpFavoriteDisplay.Location = new System.Drawing.Point(309, 261);
            this.grpFavoriteDisplay.Name = "grpFavoriteDisplay";
            this.grpFavoriteDisplay.Size = new System.Drawing.Size(426, 136);
            this.grpFavoriteDisplay.TabIndex = 18;
            this.grpFavoriteDisplay.TabStop = false;
            this.grpFavoriteDisplay.Text = "customGroupBox2";
            // 
            // grpFavoriteImage
            // 
            this.grpFavoriteImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpFavoriteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpFavoriteImage.BorderColor = System.Drawing.Color.Black;
            this.grpFavoriteImage.Location = new System.Drawing.Point(19, 18);
            this.grpFavoriteImage.Name = "grpFavoriteImage";
            this.grpFavoriteImage.Size = new System.Drawing.Size(100, 100);
            this.grpFavoriteImage.TabIndex = 21;
            this.grpFavoriteImage.TabStop = false;
            this.grpFavoriteImage.Text = "customGroupBox1";
            // 
            // lblFavoriteInfo
            // 
            this.lblFavoriteInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFavoriteInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFavoriteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoriteInfo.Location = new System.Drawing.Point(137, 18);
            this.lblFavoriteInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblFavoriteInfo.Name = "lblFavoriteInfo";
            this.lblFavoriteInfo.Size = new System.Drawing.Size(270, 100);
            this.lblFavoriteInfo.TabIndex = 20;
            this.lblFavoriteInfo.Text = "My Favorite __________";
            this.lblFavoriteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFavoriteTitle
            // 
            this.lblFavoriteTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFavoriteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoriteTitle.Location = new System.Drawing.Point(209, 71);
            this.lblFavoriteTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblFavoriteTitle.Name = "lblFavoriteTitle";
            this.lblFavoriteTitle.Size = new System.Drawing.Size(626, 51);
            this.lblFavoriteTitle.TabIndex = 17;
            this.lblFavoriteTitle.Text = "My Favorite __________";
            this.lblFavoriteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabRectangle
            // 
            this.tabRectangle.Controls.Add(this.grpRectangleContainer);
            this.tabRectangle.Controls.Add(this.lblRectangleTitle);
            this.tabRectangle.Controls.Add(this.grpRectangleControls);
            this.tabRectangle.Location = new System.Drawing.Point(4, 22);
            this.tabRectangle.Name = "tabRectangle";
            this.tabRectangle.Size = new System.Drawing.Size(1044, 486);
            this.tabRectangle.TabIndex = 4;
            this.tabRectangle.Text = "Rectangle Calculator";
            this.tabRectangle.UseVisualStyleBackColor = true;
            // 
            // grpRectangleContainer
            // 
            this.grpRectangleContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpRectangleContainer.BorderColor = System.Drawing.Color.Black;
            this.grpRectangleContainer.Controls.Add(this.lblRectangleError);
            this.grpRectangleContainer.Controls.Add(this.grpRectangle);
            this.grpRectangleContainer.Location = new System.Drawing.Point(309, 261);
            this.grpRectangleContainer.Name = "grpRectangleContainer";
            this.grpRectangleContainer.Size = new System.Drawing.Size(426, 136);
            this.grpRectangleContainer.TabIndex = 15;
            this.grpRectangleContainer.TabStop = false;
            this.grpRectangleContainer.Text = "customGroupBox2";
            // 
            // lblRectangleError
            // 
            this.lblRectangleError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRectangleError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRectangleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleError.Location = new System.Drawing.Point(52, 43);
            this.lblRectangleError.Margin = new System.Windows.Forms.Padding(0);
            this.lblRectangleError.Name = "lblRectangleError";
            this.lblRectangleError.Size = new System.Drawing.Size(322, 51);
            this.lblRectangleError.TabIndex = 16;
            this.lblRectangleError.Text = "Invalid Dimensions";
            this.lblRectangleError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRectangle
            // 
            this.grpRectangle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpRectangle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.grpRectangle.BorderColor = System.Drawing.Color.Black;
            this.grpRectangle.Location = new System.Drawing.Point(163, 17);
            this.grpRectangle.MaximumSize = new System.Drawing.Size(100, 100);
            this.grpRectangle.Name = "grpRectangle";
            this.grpRectangle.Size = new System.Drawing.Size(100, 100);
            this.grpRectangle.TabIndex = 14;
            this.grpRectangle.TabStop = false;
            this.grpRectangle.Visible = false;
            // 
            // lblRectangleTitle
            // 
            this.lblRectangleTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRectangleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleTitle.Location = new System.Drawing.Point(209, 71);
            this.lblRectangleTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblRectangleTitle.Name = "lblRectangleTitle";
            this.lblRectangleTitle.Size = new System.Drawing.Size(626, 51);
            this.lblRectangleTitle.TabIndex = 11;
            this.lblRectangleTitle.Text = "Rectangle Calculator";
            this.lblRectangleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRectangleControls
            // 
            this.grpRectangleControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpRectangleControls.AutoSize = true;
            this.grpRectangleControls.BackColor = System.Drawing.SystemColors.Control;
            this.grpRectangleControls.BorderColor = System.Drawing.Color.Black;
            this.grpRectangleControls.Controls.Add(this.btnRectangleCalculate);
            this.grpRectangleControls.Controls.Add(this.lblRectangleAreaTitle);
            this.grpRectangleControls.Controls.Add(this.txtRectangleDimensions);
            this.grpRectangleControls.Controls.Add(this.lblRectangleDimensions);
            this.grpRectangleControls.Controls.Add(this.lblRectanglePerimiterTitle);
            this.grpRectangleControls.Controls.Add(this.lblRectangleArea);
            this.grpRectangleControls.Controls.Add(this.lblRectanglePerimeter);
            this.grpRectangleControls.Location = new System.Drawing.Point(309, 140);
            this.grpRectangleControls.Name = "grpRectangleControls";
            this.grpRectangleControls.Size = new System.Drawing.Size(426, 105);
            this.grpRectangleControls.TabIndex = 10;
            this.grpRectangleControls.TabStop = false;
            // 
            // btnRectangleCalculate
            // 
            this.btnRectangleCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnRectangleCalculate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRectangleCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangleCalculate.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangleCalculate.Image")));
            this.btnRectangleCalculate.Location = new System.Drawing.Point(391, 13);
            this.btnRectangleCalculate.Margin = new System.Windows.Forms.Padding(0);
            this.btnRectangleCalculate.Name = "btnRectangleCalculate";
            this.btnRectangleCalculate.Size = new System.Drawing.Size(26, 26);
            this.btnRectangleCalculate.TabIndex = 18;
            this.btnRectangleCalculate.UseVisualStyleBackColor = false;
            // 
            // lblRectangleAreaTitle
            // 
            this.lblRectangleAreaTitle.AutoSize = true;
            this.lblRectangleAreaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleAreaTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectangleAreaTitle.Location = new System.Drawing.Point(18, 42);
            this.lblRectangleAreaTitle.Name = "lblRectangleAreaTitle";
            this.lblRectangleAreaTitle.Size = new System.Drawing.Size(47, 20);
            this.lblRectangleAreaTitle.TabIndex = 14;
            this.lblRectangleAreaTitle.Text = "Area:";
            // 
            // txtRectangleDimensions
            // 
            this.txtRectangleDimensions.BackColor = System.Drawing.SystemColors.Window;
            this.txtRectangleDimensions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRectangleDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRectangleDimensions.Location = new System.Drawing.Point(217, 13);
            this.txtRectangleDimensions.Margin = new System.Windows.Forms.Padding(0);
            this.txtRectangleDimensions.Name = "txtRectangleDimensions";
            this.txtRectangleDimensions.Size = new System.Drawing.Size(175, 26);
            this.txtRectangleDimensions.TabIndex = 13;
            // 
            // lblRectangleDimensions
            // 
            this.lblRectangleDimensions.AutoSize = true;
            this.lblRectangleDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleDimensions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectangleDimensions.Location = new System.Drawing.Point(18, 16);
            this.lblRectangleDimensions.Name = "lblRectangleDimensions";
            this.lblRectangleDimensions.Size = new System.Drawing.Size(173, 20);
            this.lblRectangleDimensions.TabIndex = 9;
            this.lblRectangleDimensions.Text = "Rectangle Dimensions:";
            // 
            // lblRectanglePerimiterTitle
            // 
            this.lblRectanglePerimiterTitle.AutoSize = true;
            this.lblRectanglePerimiterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectanglePerimiterTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectanglePerimiterTitle.Location = new System.Drawing.Point(18, 68);
            this.lblRectanglePerimiterTitle.Name = "lblRectanglePerimiterTitle";
            this.lblRectanglePerimiterTitle.Size = new System.Drawing.Size(75, 20);
            this.lblRectanglePerimiterTitle.TabIndex = 15;
            this.lblRectanglePerimiterTitle.Text = "Perimiter:";
            // 
            // lblRectangleArea
            // 
            this.lblRectangleArea.AutoSize = true;
            this.lblRectangleArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleArea.Location = new System.Drawing.Point(71, 45);
            this.lblRectangleArea.Name = "lblRectangleArea";
            this.lblRectangleArea.Size = new System.Drawing.Size(32, 15);
            this.lblRectangleArea.TabIndex = 16;
            this.lblRectangleArea.Text = "Area";
            this.lblRectangleArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRectanglePerimeter
            // 
            this.lblRectanglePerimeter.AutoSize = true;
            this.lblRectanglePerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectanglePerimeter.Location = new System.Drawing.Point(99, 71);
            this.lblRectanglePerimeter.Name = "lblRectanglePerimeter";
            this.lblRectanglePerimeter.Size = new System.Drawing.Size(61, 15);
            this.lblRectanglePerimeter.TabIndex = 17;
            this.lblRectanglePerimeter.Text = "Perimeter";
            this.lblRectanglePerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabMySchool
            // 
            this.tabMySchool.Controls.Add(this.lblMySchoolTitle);
            this.tabMySchool.Controls.Add(this.grpMySchool);
            this.tabMySchool.Location = new System.Drawing.Point(4, 22);
            this.tabMySchool.Name = "tabMySchool";
            this.tabMySchool.Padding = new System.Windows.Forms.Padding(3);
            this.tabMySchool.Size = new System.Drawing.Size(1044, 486);
            this.tabMySchool.TabIndex = 1;
            this.tabMySchool.Text = "My School";
            this.tabMySchool.UseVisualStyleBackColor = true;
            // 
            // lblMySchoolTitle
            // 
            this.lblMySchoolTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMySchoolTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySchoolTitle.Location = new System.Drawing.Point(274, 71);
            this.lblMySchoolTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblMySchoolTitle.Name = "lblMySchoolTitle";
            this.lblMySchoolTitle.Size = new System.Drawing.Size(496, 51);
            this.lblMySchoolTitle.TabIndex = 8;
            this.lblMySchoolTitle.Text = "Red River High School";
            this.lblMySchoolTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpMySchool
            // 
            this.grpMySchool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpMySchool.AutoSize = true;
            this.grpMySchool.BackColor = System.Drawing.SystemColors.Control;
            this.grpMySchool.BorderColor = System.Drawing.Color.Black;
            this.grpMySchool.Controls.Add(this.lblMySchoolMascot);
            this.grpMySchool.Controls.Add(this.picMySchoolMascot);
            this.grpMySchool.Controls.Add(this.btnMySchoolToggleMascot);
            this.grpMySchool.Location = new System.Drawing.Point(309, 140);
            this.grpMySchool.Name = "grpMySchool";
            this.grpMySchool.Size = new System.Drawing.Size(426, 105);
            this.grpMySchool.TabIndex = 9;
            this.grpMySchool.TabStop = false;
            // 
            // lblMySchoolMascot
            // 
            this.lblMySchoolMascot.AutoSize = true;
            this.lblMySchoolMascot.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySchoolMascot.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMySchoolMascot.Location = new System.Drawing.Point(50, 27);
            this.lblMySchoolMascot.Name = "lblMySchoolMascot";
            this.lblMySchoolMascot.Size = new System.Drawing.Size(134, 18);
            this.lblMySchoolMascot.TabIndex = 10;
            this.lblMySchoolMascot.Text = "Mascot: Roughriders";
            // 
            // picMySchoolMascot
            // 
            this.picMySchoolMascot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMySchoolMascot.Image = global::Mathre.My.Resources.Resources.RedRiver;
            this.picMySchoolMascot.Location = new System.Drawing.Point(268, 19);
            this.picMySchoolMascot.Name = "picMySchoolMascot";
            this.picMySchoolMascot.Size = new System.Drawing.Size(108, 66);
            this.picMySchoolMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMySchoolMascot.TabIndex = 13;
            this.picMySchoolMascot.TabStop = false;
            this.picMySchoolMascot.Visible = false;
            // 
            // btnMySchoolToggleMascot
            // 
            this.btnMySchoolToggleMascot.Location = new System.Drawing.Point(51, 60);
            this.btnMySchoolToggleMascot.Name = "btnMySchoolToggleMascot";
            this.btnMySchoolToggleMascot.Size = new System.Drawing.Size(132, 23);
            this.btnMySchoolToggleMascot.TabIndex = 9;
            this.btnMySchoolToggleMascot.Text = "Toggle Mascot Visibility";
            this.btnMySchoolToggleMascot.UseVisualStyleBackColor = true;
            // 
            // tabHelloWorld
            // 
            this.tabHelloWorld.BackColor = System.Drawing.Color.White;
            this.tabHelloWorld.Controls.Add(this.grpHelloWorld);
            this.tabHelloWorld.Controls.Add(this.lblHelloWorldTitle);
            this.tabHelloWorld.Location = new System.Drawing.Point(4, 22);
            this.tabHelloWorld.Margin = new System.Windows.Forms.Padding(0);
            this.tabHelloWorld.Name = "tabHelloWorld";
            this.tabHelloWorld.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelloWorld.Size = new System.Drawing.Size(1044, 486);
            this.tabHelloWorld.TabIndex = 0;
            this.tabHelloWorld.Text = "Hello World";
            // 
            // grpHelloWorld
            // 
            this.grpHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpHelloWorld.AutoSize = true;
            this.grpHelloWorld.BackColor = System.Drawing.SystemColors.Control;
            this.grpHelloWorld.BorderColor = System.Drawing.Color.Black;
            this.grpHelloWorld.Controls.Add(this.picHelloWorldGerman);
            this.grpHelloWorld.Controls.Add(this.btnHelloWorldFrench);
            this.grpHelloWorld.Controls.Add(this.picHelloWorldEnglish);
            this.grpHelloWorld.Controls.Add(this.picHelloWorldFrench);
            this.grpHelloWorld.Controls.Add(this.btnHelloWorldReset);
            this.grpHelloWorld.Controls.Add(this.btnHelloWorldGerman);
            this.grpHelloWorld.Controls.Add(this.btnHelloWorldEnglish);
            this.grpHelloWorld.Location = new System.Drawing.Point(309, 140);
            this.grpHelloWorld.Name = "grpHelloWorld";
            this.grpHelloWorld.Size = new System.Drawing.Size(426, 105);
            this.grpHelloWorld.TabIndex = 7;
            this.grpHelloWorld.TabStop = false;
            // 
            // picHelloWorldGerman
            // 
            this.picHelloWorldGerman.Image = global::Mathre.My.Resources.Resources.German;
            this.picHelloWorldGerman.Location = new System.Drawing.Point(293, 21);
            this.picHelloWorldGerman.Name = "picHelloWorldGerman";
            this.picHelloWorldGerman.Size = new System.Drawing.Size(31, 25);
            this.picHelloWorldGerman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelloWorldGerman.TabIndex = 13;
            this.picHelloWorldGerman.TabStop = false;
            // 
            // btnHelloWorldFrench
            // 
            this.btnHelloWorldFrench.AutoSize = true;
            this.btnHelloWorldFrench.Location = new System.Drawing.Point(201, 25);
            this.btnHelloWorldFrench.Name = "btnHelloWorldFrench";
            this.btnHelloWorldFrench.Size = new System.Drawing.Size(58, 17);
            this.btnHelloWorldFrench.TabIndex = 10;
            this.btnHelloWorldFrench.Text = "French";
            this.btnHelloWorldFrench.UseVisualStyleBackColor = true;
            // 
            // picHelloWorldEnglish
            // 
            this.picHelloWorldEnglish.Image = global::Mathre.My.Resources.Resources.English;
            this.picHelloWorldEnglish.Location = new System.Drawing.Point(34, 21);
            this.picHelloWorldEnglish.Name = "picHelloWorldEnglish";
            this.picHelloWorldEnglish.Size = new System.Drawing.Size(31, 25);
            this.picHelloWorldEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelloWorldEnglish.TabIndex = 12;
            this.picHelloWorldEnglish.TabStop = false;
            // 
            // picHelloWorldFrench
            // 
            this.picHelloWorldFrench.Image = global::Mathre.My.Resources.Resources.French;
            this.picHelloWorldFrench.Location = new System.Drawing.Point(164, 21);
            this.picHelloWorldFrench.Name = "picHelloWorldFrench";
            this.picHelloWorldFrench.Size = new System.Drawing.Size(31, 25);
            this.picHelloWorldFrench.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelloWorldFrench.TabIndex = 11;
            this.picHelloWorldFrench.TabStop = false;
            // 
            // btnHelloWorldReset
            // 
            this.btnHelloWorldReset.Location = new System.Drawing.Point(169, 61);
            this.btnHelloWorldReset.Name = "btnHelloWorldReset";
            this.btnHelloWorldReset.Size = new System.Drawing.Size(75, 23);
            this.btnHelloWorldReset.TabIndex = 9;
            this.btnHelloWorldReset.Text = "Reset";
            this.btnHelloWorldReset.UseVisualStyleBackColor = true;
            // 
            // btnHelloWorldGerman
            // 
            this.btnHelloWorldGerman.AutoSize = true;
            this.btnHelloWorldGerman.Location = new System.Drawing.Point(330, 25);
            this.btnHelloWorldGerman.Name = "btnHelloWorldGerman";
            this.btnHelloWorldGerman.Size = new System.Drawing.Size(62, 17);
            this.btnHelloWorldGerman.TabIndex = 8;
            this.btnHelloWorldGerman.Text = "German";
            this.btnHelloWorldGerman.UseVisualStyleBackColor = true;
            // 
            // btnHelloWorldEnglish
            // 
            this.btnHelloWorldEnglish.AutoSize = true;
            this.btnHelloWorldEnglish.Checked = true;
            this.btnHelloWorldEnglish.Location = new System.Drawing.Point(71, 25);
            this.btnHelloWorldEnglish.Name = "btnHelloWorldEnglish";
            this.btnHelloWorldEnglish.Size = new System.Drawing.Size(59, 17);
            this.btnHelloWorldEnglish.TabIndex = 7;
            this.btnHelloWorldEnglish.TabStop = true;
            this.btnHelloWorldEnglish.Text = "English";
            this.btnHelloWorldEnglish.UseVisualStyleBackColor = true;
            // 
            // lblHelloWorldTitle
            // 
            this.lblHelloWorldTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelloWorldTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorldTitle.Location = new System.Drawing.Point(309, 71);
            this.lblHelloWorldTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblHelloWorldTitle.Name = "lblHelloWorldTitle";
            this.lblHelloWorldTitle.Size = new System.Drawing.Size(426, 51);
            this.lblHelloWorldTitle.TabIndex = 5;
            this.lblHelloWorldTitle.Text = "Hello World";
            this.lblHelloWorldTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMathre
            // 
            this.tabMathre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMathre.Controls.Add(this.tabHelloWorld);
            this.tabMathre.Controls.Add(this.tabMySchool);
            this.tabMathre.Controls.Add(this.tabRectangle);
            this.tabMathre.Controls.Add(this.tabMyFavorites);
            this.tabMathre.Controls.Add(this.tabTemperature);
            this.tabMathre.Controls.Add(this.tabDigits);
            this.tabMathre.Controls.Add(this.tabChangeMaker);
            this.tabMathre.Controls.Add(this.tabPizza);
            this.tabMathre.Controls.Add(this.tabUnknown);
            this.tabMathre.Controls.Add(this.tabSecret);
            this.tabMathre.Location = new System.Drawing.Point(0, 29);
            this.tabMathre.Margin = new System.Windows.Forms.Padding(0);
            this.tabMathre.Name = "tabMathre";
            this.tabMathre.Padding = new System.Drawing.Point(0, 0);
            this.tabMathre.SelectedIndex = 0;
            this.tabMathre.Size = new System.Drawing.Size(1052, 512);
            this.tabMathre.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMathre.TabIndex = 4;
            // 
            // tabTemperature
            // 
            this.tabTemperature.Controls.Add(this.grpTemperatureResults);
            this.tabTemperature.Controls.Add(this.lblTemperatureTitle);
            this.tabTemperature.Controls.Add(this.grpTemperature);
            this.tabTemperature.Location = new System.Drawing.Point(4, 22);
            this.tabTemperature.Name = "tabTemperature";
            this.tabTemperature.Size = new System.Drawing.Size(1044, 486);
            this.tabTemperature.TabIndex = 6;
            this.tabTemperature.Text = "Temperature Converter";
            this.tabTemperature.UseVisualStyleBackColor = true;
            // 
            // grpTemperatureResults
            // 
            this.grpTemperatureResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTemperatureResults.BorderColor = System.Drawing.Color.Black;
            this.grpTemperatureResults.Controls.Add(this.lblCelsiusDisplay);
            this.grpTemperatureResults.Controls.Add(this.lblFahrenheitDisplay);
            this.grpTemperatureResults.Controls.Add(this.lblCelsiusDisplayLabel);
            this.grpTemperatureResults.Controls.Add(this.lblFahrenheitDisplayLabel);
            this.grpTemperatureResults.Location = new System.Drawing.Point(309, 261);
            this.grpTemperatureResults.Name = "grpTemperatureResults";
            this.grpTemperatureResults.Size = new System.Drawing.Size(426, 81);
            this.grpTemperatureResults.TabIndex = 18;
            this.grpTemperatureResults.TabStop = false;
            this.grpTemperatureResults.Text = "customGroupBox2";
            // 
            // lblCelsiusDisplay
            // 
            this.lblCelsiusDisplay.AutoSize = true;
            this.lblCelsiusDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsiusDisplay.Location = new System.Drawing.Point(199, 45);
            this.lblCelsiusDisplay.Name = "lblCelsiusDisplay";
            this.lblCelsiusDisplay.Size = new System.Drawing.Size(78, 15);
            this.lblCelsiusDisplay.TabIndex = 17;
            this.lblCelsiusDisplay.Text = "Temperature";
            this.lblCelsiusDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFahrenheitDisplay
            // 
            this.lblFahrenheitDisplay.AutoSize = true;
            this.lblFahrenheitDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheitDisplay.Location = new System.Drawing.Point(225, 19);
            this.lblFahrenheitDisplay.Name = "lblFahrenheitDisplay";
            this.lblFahrenheitDisplay.Size = new System.Drawing.Size(78, 15);
            this.lblFahrenheitDisplay.TabIndex = 16;
            this.lblFahrenheitDisplay.Text = "Temperature";
            this.lblFahrenheitDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCelsiusDisplayLabel
            // 
            this.lblCelsiusDisplayLabel.AutoSize = true;
            this.lblCelsiusDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsiusDisplayLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCelsiusDisplayLabel.Location = new System.Drawing.Point(18, 42);
            this.lblCelsiusDisplayLabel.Name = "lblCelsiusDisplayLabel";
            this.lblCelsiusDisplayLabel.Size = new System.Drawing.Size(175, 20);
            this.lblCelsiusDisplayLabel.TabIndex = 15;
            this.lblCelsiusDisplayLabel.Text = "Temperature in Celsius:";
            // 
            // lblFahrenheitDisplayLabel
            // 
            this.lblFahrenheitDisplayLabel.AutoSize = true;
            this.lblFahrenheitDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheitDisplayLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFahrenheitDisplayLabel.Location = new System.Drawing.Point(18, 16);
            this.lblFahrenheitDisplayLabel.Name = "lblFahrenheitDisplayLabel";
            this.lblFahrenheitDisplayLabel.Size = new System.Drawing.Size(201, 20);
            this.lblFahrenheitDisplayLabel.TabIndex = 14;
            this.lblFahrenheitDisplayLabel.Text = "Temperature in Fahrenheit:";
            // 
            // lblTemperatureTitle
            // 
            this.lblTemperatureTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTemperatureTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureTitle.Location = new System.Drawing.Point(209, 71);
            this.lblTemperatureTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemperatureTitle.Name = "lblTemperatureTitle";
            this.lblTemperatureTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTemperatureTitle.TabIndex = 17;
            this.lblTemperatureTitle.Text = "Temperature Converter";
            this.lblTemperatureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTemperature
            // 
            this.grpTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTemperature.AutoSize = true;
            this.grpTemperature.BackColor = System.Drawing.SystemColors.Control;
            this.grpTemperature.BorderColor = System.Drawing.Color.Black;
            this.grpTemperature.Controls.Add(this.btnCelsius);
            this.grpTemperature.Controls.Add(this.btnFahrenheit);
            this.grpTemperature.Controls.Add(this.txtTemperature);
            this.grpTemperature.Controls.Add(this.lblTemperature);
            this.grpTemperature.Location = new System.Drawing.Point(309, 140);
            this.grpTemperature.Name = "grpTemperature";
            this.grpTemperature.Size = new System.Drawing.Size(426, 105);
            this.grpTemperature.TabIndex = 16;
            this.grpTemperature.TabStop = false;
            // 
            // btnCelsius
            // 
            this.btnCelsius.AutoSize = true;
            this.btnCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelsius.Location = new System.Drawing.Point(275, 61);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(78, 24);
            this.btnCelsius.TabIndex = 26;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.AutoSize = true;
            this.btnFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFahrenheit.Location = new System.Drawing.Point(73, 61);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(104, 24);
            this.btnFahrenheit.TabIndex = 25;
            this.btnFahrenheit.Text = "Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            // 
            // txtTemperature
            // 
            this.txtTemperature.BackColor = System.Drawing.SystemColors.Window;
            this.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(148, 13);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(269, 26);
            this.txtTemperature.TabIndex = 13;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTemperature.Location = new System.Drawing.Point(18, 16);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(104, 20);
            this.lblTemperature.TabIndex = 9;
            this.lblTemperature.Text = "Temperature:";
            // 
            // tabDigits
            // 
            this.tabDigits.Controls.Add(this.grpDigitsResults);
            this.tabDigits.Controls.Add(this.lblDigitsTitle);
            this.tabDigits.Controls.Add(this.grpDigits);
            this.tabDigits.Location = new System.Drawing.Point(4, 22);
            this.tabDigits.Name = "tabDigits";
            this.tabDigits.Size = new System.Drawing.Size(1044, 486);
            this.tabDigits.TabIndex = 7;
            this.tabDigits.Text = "Digit Separator";
            this.tabDigits.UseVisualStyleBackColor = true;
            // 
            // grpDigitsResults
            // 
            this.grpDigitsResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDigitsResults.BorderColor = System.Drawing.Color.Black;
            this.grpDigitsResults.Controls.Add(this.pnlDigitsResults);
            this.grpDigitsResults.Location = new System.Drawing.Point(309, 261);
            this.grpDigitsResults.Name = "grpDigitsResults";
            this.grpDigitsResults.Size = new System.Drawing.Size(426, 136);
            this.grpDigitsResults.TabIndex = 21;
            this.grpDigitsResults.TabStop = false;
            this.grpDigitsResults.Text = "customGroupBox2";
            // 
            // pnlDigitsResults
            // 
            this.pnlDigitsResults.AutoScroll = true;
            this.pnlDigitsResults.Controls.Add(this.lblDigitsResultsLabel);
            this.pnlDigitsResults.Controls.Add(this.lblDigitsListOdds);
            this.pnlDigitsResults.Controls.Add(this.lblDigitsListEvens);
            this.pnlDigitsResults.Location = new System.Drawing.Point(2, 2);
            this.pnlDigitsResults.Name = "pnlDigitsResults";
            this.pnlDigitsResults.Size = new System.Drawing.Size(422, 132);
            this.pnlDigitsResults.TabIndex = 22;
            // 
            // lblDigitsResultsLabel
            // 
            this.lblDigitsResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitsResultsLabel.Location = new System.Drawing.Point(25, 14);
            this.lblDigitsResultsLabel.Name = "lblDigitsResultsLabel";
            this.lblDigitsResultsLabel.Size = new System.Drawing.Size(373, 27);
            this.lblDigitsResultsLabel.TabIndex = 3;
            this.lblDigitsResultsLabel.Text = "Digits";
            this.lblDigitsResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDigitsListOdds
            // 
            this.lblDigitsListOdds.AutoSize = true;
            this.lblDigitsListOdds.Location = new System.Drawing.Point(124, 45);
            this.lblDigitsListOdds.Name = "lblDigitsListOdds";
            this.lblDigitsListOdds.Size = new System.Drawing.Size(51, 13);
            this.lblDigitsListOdds.TabIndex = 2;
            this.lblDigitsListOdds.Text = "Digit #: #";
            // 
            // lblDigitsListEvens
            // 
            this.lblDigitsListEvens.AutoSize = true;
            this.lblDigitsListEvens.Location = new System.Drawing.Point(247, 45);
            this.lblDigitsListEvens.Name = "lblDigitsListEvens";
            this.lblDigitsListEvens.Size = new System.Drawing.Size(51, 13);
            this.lblDigitsListEvens.TabIndex = 1;
            this.lblDigitsListEvens.Text = "Digit #: #";
            // 
            // lblDigitsTitle
            // 
            this.lblDigitsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDigitsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitsTitle.Location = new System.Drawing.Point(209, 71);
            this.lblDigitsTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblDigitsTitle.Name = "lblDigitsTitle";
            this.lblDigitsTitle.Size = new System.Drawing.Size(626, 51);
            this.lblDigitsTitle.TabIndex = 20;
            this.lblDigitsTitle.Text = "Numerical Digit Separator";
            this.lblDigitsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDigits
            // 
            this.grpDigits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDigits.AutoSize = true;
            this.grpDigits.BackColor = System.Drawing.SystemColors.Control;
            this.grpDigits.BorderColor = System.Drawing.Color.Black;
            this.grpDigits.Controls.Add(this.txtNumber);
            this.grpDigits.Controls.Add(this.lblDigits);
            this.grpDigits.Controls.Add(this.lblDigitsCount);
            this.grpDigits.Controls.Add(this.lblDigitsCountLabel);
            this.grpDigits.Location = new System.Drawing.Point(309, 140);
            this.grpDigits.Name = "grpDigits";
            this.grpDigits.Size = new System.Drawing.Size(426, 105);
            this.grpDigits.TabIndex = 19;
            this.grpDigits.TabStop = false;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(113, 13);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(304, 26);
            this.txtNumber.TabIndex = 13;
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDigits.Location = new System.Drawing.Point(18, 16);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(69, 20);
            this.lblDigits.TabIndex = 9;
            this.lblDigits.Text = "Number:";
            // 
            // lblDigitsCount
            // 
            this.lblDigitsCount.AutoSize = true;
            this.lblDigitsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitsCount.Location = new System.Drawing.Point(155, 64);
            this.lblDigitsCount.Name = "lblDigitsCount";
            this.lblDigitsCount.Size = new System.Drawing.Size(38, 15);
            this.lblDigitsCount.TabIndex = 17;
            this.lblDigitsCount.Text = "Digits";
            this.lblDigitsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDigitsCountLabel
            // 
            this.lblDigitsCountLabel.AutoSize = true;
            this.lblDigitsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitsCountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDigitsCountLabel.Location = new System.Drawing.Point(18, 61);
            this.lblDigitsCountLabel.Name = "lblDigitsCountLabel";
            this.lblDigitsCountLabel.Size = new System.Drawing.Size(131, 20);
            this.lblDigitsCountLabel.TabIndex = 14;
            this.lblDigitsCountLabel.Text = "Number of Digits:";
            // 
            // tabChangeMaker
            // 
            this.tabChangeMaker.Controls.Add(this.customGroupBox1);
            this.tabChangeMaker.Controls.Add(this.label5);
            this.tabChangeMaker.Controls.Add(this.customGroupBox2);
            this.tabChangeMaker.Location = new System.Drawing.Point(4, 22);
            this.tabChangeMaker.Name = "tabChangeMaker";
            this.tabChangeMaker.Size = new System.Drawing.Size(1044, 486);
            this.tabChangeMaker.TabIndex = 8;
            this.tabChangeMaker.Text = "Change Maker";
            this.tabChangeMaker.UseVisualStyleBackColor = true;
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.customGroupBox1.Controls.Add(this.label30);
            this.customGroupBox1.Controls.Add(this.label29);
            this.customGroupBox1.Controls.Add(this.label28);
            this.customGroupBox1.Controls.Add(this.label27);
            this.customGroupBox1.Controls.Add(this.label26);
            this.customGroupBox1.Controls.Add(this.label25);
            this.customGroupBox1.Controls.Add(this.label24);
            this.customGroupBox1.Controls.Add(this.label23);
            this.customGroupBox1.Controls.Add(this.label1);
            this.customGroupBox1.Controls.Add(this.label22);
            this.customGroupBox1.Controls.Add(this.label21);
            this.customGroupBox1.Controls.Add(this.label20);
            this.customGroupBox1.Controls.Add(this.label19);
            this.customGroupBox1.Controls.Add(this.label18);
            this.customGroupBox1.Controls.Add(this.label17);
            this.customGroupBox1.Controls.Add(this.label16);
            this.customGroupBox1.Controls.Add(this.label15);
            this.customGroupBox1.Controls.Add(this.label13);
            this.customGroupBox1.Controls.Add(this.label2);
            this.customGroupBox1.Controls.Add(this.label3);
            this.customGroupBox1.Controls.Add(this.label4);
            this.customGroupBox1.Location = new System.Drawing.Point(309, 261);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Size = new System.Drawing.Size(426, 136);
            this.customGroupBox1.TabIndex = 21;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "customGroupBox2";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(324, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 15);
            this.label30.TabIndex = 35;
            this.label30.Text = "Count";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(348, 35);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(39, 15);
            this.label29.TabIndex = 34;
            this.label29.Text = "Count";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(331, 61);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 15);
            this.label28.TabIndex = 33;
            this.label28.Text = "Count";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(336, 87);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 15);
            this.label27.TabIndex = 32;
            this.label27.Text = "Count";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(343, 113);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 15);
            this.label26.TabIndex = 31;
            this.label26.Text = "Count";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(158, 113);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 15);
            this.label25.TabIndex = 30;
            this.label25.Text = "Count";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(156, 87);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 15);
            this.label24.TabIndex = 29;
            this.label24.Text = "Count";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(184, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 15);
            this.label23.TabIndex = 28;
            this.label23.Text = "Count";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(267, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 20);
            this.label22.TabIndex = 26;
            this.label22.Text = "Pennies:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(267, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 20);
            this.label21.TabIndex = 25;
            this.label21.Text = "Nickels:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(267, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 20);
            this.label20.TabIndex = 24;
            this.label20.Text = "Dimes:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(267, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Quarters:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(267, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "Ones:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(102, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Fives:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(102, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Tens:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(102, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Twenties:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(102, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Fifties:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(102, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hundreds:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Change:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(626, 51);
            this.label5.TabIndex = 20;
            this.label5.Text = "Change Maker";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customGroupBox2
            // 
            this.customGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customGroupBox2.AutoSize = true;
            this.customGroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.customGroupBox2.BorderColor = System.Drawing.Color.Black;
            this.customGroupBox2.Controls.Add(this.radioButton1);
            this.customGroupBox2.Controls.Add(this.radioButton2);
            this.customGroupBox2.Controls.Add(this.textBox1);
            this.customGroupBox2.Controls.Add(this.label6);
            this.customGroupBox2.Location = new System.Drawing.Point(309, 140);
            this.customGroupBox2.Name = "customGroupBox2";
            this.customGroupBox2.Size = new System.Drawing.Size(426, 105);
            this.customGroupBox2.TabIndex = 19;
            this.customGroupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(275, 61);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 24);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.Text = "Celsius";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(73, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.Text = "Fahrenheit";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(125, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 26);
            this.textBox1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Paid Amount:";
            // 
            // tabPizza
            // 
            this.tabPizza.Controls.Add(this.customGroupBox5);
            this.tabPizza.Controls.Add(this.customGroupBox3);
            this.tabPizza.Controls.Add(this.label11);
            this.tabPizza.Location = new System.Drawing.Point(4, 22);
            this.tabPizza.Name = "tabPizza";
            this.tabPizza.Size = new System.Drawing.Size(1044, 486);
            this.tabPizza.TabIndex = 9;
            this.tabPizza.Text = "Pizza Delivery";
            this.tabPizza.UseVisualStyleBackColor = true;
            // 
            // customGroupBox5
            // 
            this.customGroupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customGroupBox5.AutoSize = true;
            this.customGroupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.customGroupBox5.BorderColor = System.Drawing.Color.Black;
            this.customGroupBox5.Controls.Add(this.textBox3);
            this.customGroupBox5.Controls.Add(this.label12);
            this.customGroupBox5.Controls.Add(this.radioButton3);
            this.customGroupBox5.Controls.Add(this.radioButton4);
            this.customGroupBox5.Controls.Add(this.textBox2);
            this.customGroupBox5.Controls.Add(this.label14);
            this.customGroupBox5.Location = new System.Drawing.Point(309, 140);
            this.customGroupBox5.Name = "customGroupBox5";
            this.customGroupBox5.Size = new System.Drawing.Size(426, 105);
            this.customGroupBox5.TabIndex = 25;
            this.customGroupBox5.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(265, 13);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 26);
            this.textBox3.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(225, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tip:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(275, 61);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 24);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.Text = "Delivery";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(73, 61);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 24);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.Text = "Takeout";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(65, 14);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 26);
            this.textBox2.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(18, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Size:";
            // 
            // customGroupBox3
            // 
            this.customGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customGroupBox3.BorderColor = System.Drawing.Color.Black;
            this.customGroupBox3.Controls.Add(this.label7);
            this.customGroupBox3.Controls.Add(this.label8);
            this.customGroupBox3.Controls.Add(this.label9);
            this.customGroupBox3.Controls.Add(this.label10);
            this.customGroupBox3.Location = new System.Drawing.Point(309, 261);
            this.customGroupBox3.Name = "customGroupBox3";
            this.customGroupBox3.Size = new System.Drawing.Size(426, 81);
            this.customGroupBox3.TabIndex = 24;
            this.customGroupBox3.TabStop = false;
            this.customGroupBox3.Text = "customGroupBox2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Temperature";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Temperature";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(18, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Temperature in Celsius:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(18, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Temperature in Fahrenheit:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(209, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(626, 51);
            this.label11.TabIndex = 23;
            this.label11.Text = "Pizza Delivery";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMathre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1047, 526);
            this.Controls.Add(this.tabMathre);
            this.Controls.Add(this.mnuBaseLayer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuBaseLayer;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FrmMathre";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.FormLoad);
            this.mnuBaseLayer.ResumeLayout(false);
            this.mnuBaseLayer.PerformLayout();
            this.tabSecret.ResumeLayout(false);
            this.tabSecret.PerformLayout();
            this.grpSecret.ResumeLayout(false);
            this.grpSecret.PerformLayout();
            this.tabMyFavorites.ResumeLayout(false);
            this.tabMyFavorites.PerformLayout();
            this.grpFavoriteControls.ResumeLayout(false);
            this.grpFavoriteControls.PerformLayout();
            this.grpFavoriteDisplay.ResumeLayout(false);
            this.tabRectangle.ResumeLayout(false);
            this.tabRectangle.PerformLayout();
            this.grpRectangleContainer.ResumeLayout(false);
            this.grpRectangleControls.ResumeLayout(false);
            this.grpRectangleControls.PerformLayout();
            this.tabMySchool.ResumeLayout(false);
            this.tabMySchool.PerformLayout();
            this.grpMySchool.ResumeLayout(false);
            this.grpMySchool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).EndInit();
            this.tabHelloWorld.ResumeLayout(false);
            this.tabHelloWorld.PerformLayout();
            this.grpHelloWorld.ResumeLayout(false);
            this.grpHelloWorld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldGerman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldFrench)).EndInit();
            this.tabMathre.ResumeLayout(false);
            this.tabTemperature.ResumeLayout(false);
            this.tabTemperature.PerformLayout();
            this.grpTemperatureResults.ResumeLayout(false);
            this.grpTemperatureResults.PerformLayout();
            this.grpTemperature.ResumeLayout(false);
            this.grpTemperature.PerformLayout();
            this.tabDigits.ResumeLayout(false);
            this.tabDigits.PerformLayout();
            this.grpDigitsResults.ResumeLayout(false);
            this.pnlDigitsResults.ResumeLayout(false);
            this.pnlDigitsResults.PerformLayout();
            this.grpDigits.ResumeLayout(false);
            this.grpDigits.PerformLayout();
            this.tabChangeMaker.ResumeLayout(false);
            this.tabChangeMaker.PerformLayout();
            this.customGroupBox1.ResumeLayout(false);
            this.customGroupBox1.PerformLayout();
            this.customGroupBox2.ResumeLayout(false);
            this.customGroupBox2.PerformLayout();
            this.tabPizza.ResumeLayout(false);
            this.tabPizza.PerformLayout();
            this.customGroupBox5.ResumeLayout(false);
            this.customGroupBox5.PerformLayout();
            this.customGroupBox3.ResumeLayout(false);
            this.customGroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal MenuStrip mnuBaseLayer;
        internal ToolStripMenuItem mnuFile;
        internal ToolStripMenuItem mnuEdit;
        internal ToolStripMenuItem mnuSecret;
        internal ToolStripMenuItem mnuRecolor;
        internal ToolStripMenuItem mnuDarkMode;
        internal ToolStripMenuItem mnuTechnicolor;
        internal ToolStripMenuItem mnuRandomify;
        internal ToolStripMenuItem mnuView;
        private ToolStripMenuItem mnuHelloWorld;
        private ToolStripMenuItem mnuMySchool;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuHelloWorldLanguage;
        private ToolStripMenuItem mnuHelloWorldLanguageEnglish;
        private ToolStripMenuItem mnuHelloWorldLanguageFrench;
        private ToolStripMenuItem mnuHelloWorldLanguageGerman;
        private ToolStripMenuItem mnuHelloWorldReset;
        private ToolStripMenuItem mnuMySchoolToggleMascot;
		private ImageList imgFavoriteImages;
		internal TabPage tabUnknown;
		internal TabPage tabSecret;
		internal Label lblSecretTitle;
		internal CustomGroupBox grpSecret;
		internal RadioButton btnSecretDisable;
		internal RadioButton btnSecretEnable;
		internal TextBox txtSecretPassword;
		internal Label lblSecretPrompt;
		internal TabPage tabMyFavorites;
		private CustomGroupBox grpFavoriteDisplay;
		internal Label lblFavoriteTitle;
		internal TabPage tabRectangle;
		private CustomGroupBox grpRectangleContainer;
		private CustomGroupBox grpRectangle;
		internal Label lblRectangleTitle;
		internal CustomGroupBox grpRectangleControls;
		private Button btnRectangleCalculate;
		internal Label lblRectangleAreaTitle;
		internal TextBox txtRectangleDimensions;
		internal Label lblRectangleDimensions;
		internal Label lblRectanglePerimiterTitle;
		private Label lblRectangleArea;
		private Label lblRectanglePerimeter;
		internal TabPage tabMySchool;
		internal Label lblMySchoolTitle;
		internal CustomGroupBox grpMySchool;
		private Label lblMySchoolMascot;
		internal PictureBox picMySchoolMascot;
		internal Button btnMySchoolToggleMascot;
		internal TabPage tabHelloWorld;
		internal CustomGroupBox grpHelloWorld;
		internal PictureBox picHelloWorldGerman;
		internal RadioButton btnHelloWorldFrench;
		internal PictureBox picHelloWorldEnglish;
		internal PictureBox picHelloWorldFrench;
		internal Button btnHelloWorldReset;
		internal RadioButton btnHelloWorldGerman;
		internal RadioButton btnHelloWorldEnglish;
		internal Label lblHelloWorldTitle;
		internal TabControl tabMathre;
		internal Label lblRectangleError;
		internal CustomGroupBox grpFavoriteControls;
		private RadioButton btnFavoriteMovie;
		private RadioButton btnFavoriteColor;
		private RadioButton btnFavoriteFruit;
		private RadioButton btnFavoriteActor;
		private RadioButton btnFavoriteHobby;
		internal Label lblFavoriteInfo;
		private ToolStripMenuItem mnuRectangle;
		private ToolStripMenuItem mnuRectangleCalculate;
		private ToolStripMenuItem mnuFavorites;
		private ToolStripMenuItem mnuFavoriteActor;
		private ToolStripMenuItem mnuFavoriteMovie;
		private ToolStripMenuItem mnuFavoriteFruit;
		private ToolStripMenuItem mnuFavoriteColor;
		private ToolStripMenuItem mnuFavoriteHobby;
		private CustomGroupBox grpFavoriteImage;
		private TabPage tabTemperature;
		private TabPage tabDigits;
		private CustomGroupBox grpTemperatureResults;
		internal Label lblTemperatureTitle;
		internal CustomGroupBox grpTemperature;
		internal Label lblFahrenheitDisplayLabel;
		internal TextBox txtTemperature;
		internal Label lblTemperature;
		internal Label lblCelsiusDisplayLabel;
		private Label lblFahrenheitDisplay;
		private Label lblCelsiusDisplay;
		private CustomGroupBox grpDigitsResults;
		internal Label lblDigitsTitle;
		internal CustomGroupBox grpDigits;
		internal TextBox txtNumber;
		internal Label lblDigits;
		private Panel pnlDigitsResults;
		private Label lblDigitsListOdds;
		private Label lblDigitsListEvens;
		private RadioButton btnCelsius;
		private RadioButton btnFahrenheit;
		private Label lblDigitsResultsLabel;
		private Label lblDigitsCount;
		internal Label lblDigitsCountLabel;
		private ToolStripMenuItem mnuTemperature;
		private ToolStripMenuItem mnuTemperatureFahrenheit;
		private ToolStripMenuItem mnuTemperatureCelsius;
		private ToolStripMenuItem mnuDigits;
		private ToolStripMenuItem mnuDigitsCalculate;
		private ToolStripMenuItem mnuViewHelloWorld;
		private ToolStripMenuItem mnuViewMySchool;
		private ToolStripMenuItem mnuViewRectangle;
		private ToolStripMenuItem mnuViewMyFavorites;
		private ToolStripMenuItem mnuViewTemperature;
		private ToolStripMenuItem mnuViewDigits;
		private ToolStripMenuItem mnuViewUnknown;
		private TabPage tabChangeMaker;
		private CustomGroupBox customGroupBox1;
		private Label label2;
		internal Label label4;
		internal Label label5;
		internal CustomGroupBox customGroupBox2;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		internal TextBox textBox1;
		internal Label label6;
		private TabPage tabPizza;
		internal CustomGroupBox customGroupBox5;
		internal Label label12;
		private RadioButton radioButton3;
		private RadioButton radioButton4;
		internal TextBox textBox2;
		internal Label label14;
		private CustomGroupBox customGroupBox3;
		private Label label7;
		private Label label8;
		internal Label label9;
		internal Label label10;
		internal Label label11;
		internal Label label22;
		internal Label label21;
		internal Label label20;
		internal Label label19;
		internal Label label18;
		internal Label label17;
		internal Label label16;
		internal Label label15;
		internal Label label13;
		internal Label label3;
		internal TextBox textBox3;
		private Label label30;
		private Label label29;
		private Label label28;
		private Label label27;
		private Label label26;
		private Label label25;
		private Label label24;
		private Label label23;
		private Label label1;
	}
}
