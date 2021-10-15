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
            this.mnuHelloWorldReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMySchool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMySchoolToggleMascot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangleCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteActor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteFruit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteHobby = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemperature = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemperatureFahrenheit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemperatureCelsius = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDigits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDigitsCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPizza = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPizzaTakeout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPizzaDelivery = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.imgFavoriteImages = new System.Windows.Forms.ImageList(this.components);
            this.mnuHelloWorldLanguageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPizzaDollars = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPizzaPercent = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSecret = new System.Windows.Forms.TabPage();
            this.lblSecretTitle = new System.Windows.Forms.Label();
            this.pnlSecret = new System.Windows.Forms.Panel();
            this.txtSecretPassword = new System.Windows.Forms.TextBox();
            this.btnSecretEnable = new System.Windows.Forms.RadioButton();
            this.lblSecretPrompt = new System.Windows.Forms.Label();
            this.btnSecretDisable = new System.Windows.Forms.RadioButton();
            this.tabUnknown = new System.Windows.Forms.TabPage();
            this.tabPizza = new System.Windows.Forms.TabPage();
            this.lblPizzaTitle = new System.Windows.Forms.Label();
            this.pnlPizza = new System.Windows.Forms.Panel();
            this.txtPizzaSize = new System.Windows.Forms.TextBox();
            this.lblPizzaTip = new System.Windows.Forms.Label();
            this.pnlTip = new System.Windows.Forms.Panel();
            this.btnDollars = new System.Windows.Forms.RadioButton();
            this.btnPercent = new System.Windows.Forms.RadioButton();
            this.txtPizzaTip = new System.Windows.Forms.TextBox();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.pnlDiningType = new System.Windows.Forms.Panel();
            this.btnDelivery = new System.Windows.Forms.RadioButton();
            this.btnTakeout = new System.Windows.Forms.RadioButton();
            this.pnlPizzaCost = new System.Windows.Forms.Panel();
            this.lblPizzaCost = new System.Windows.Forms.Label();
            this.lblPizzaCostAmount = new System.Windows.Forms.Label();
            this.pnlPizzaViewer = new System.Windows.Forms.Panel();
            this.tabChange = new System.Windows.Forms.TabPage();
            this.lblChangeMakerTitle = new System.Windows.Forms.Label();
            this.pnlChangeMaker = new System.Windows.Forms.Panel();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNickels = new System.Windows.Forms.Label();
            this.lblDimes = new System.Windows.Forms.Label();
            this.lblPennies = new System.Windows.Forms.Label();
            this.lblQuarters = new System.Windows.Forms.Label();
            this.lblFiftiesCount = new System.Windows.Forms.Label();
            this.lblOnes = new System.Windows.Forms.Label();
            this.lblTwentiesCount = new System.Windows.Forms.Label();
            this.lblFives = new System.Windows.Forms.Label();
            this.lblTensCount = new System.Windows.Forms.Label();
            this.lblTens = new System.Windows.Forms.Label();
            this.lblFivesCount = new System.Windows.Forms.Label();
            this.lblTwenties = new System.Windows.Forms.Label();
            this.lblPenniesCount = new System.Windows.Forms.Label();
            this.lblFifties = new System.Windows.Forms.Label();
            this.lblNickelsCount = new System.Windows.Forms.Label();
            this.lblHundredsCount = new System.Windows.Forms.Label();
            this.lblDimesCount = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblQuartersCount = new System.Windows.Forms.Label();
            this.lblHundreds = new System.Windows.Forms.Label();
            this.lblOnesCount = new System.Windows.Forms.Label();
            this.tabDigits = new System.Windows.Forms.TabPage();
            this.lblDigitsTitle = new System.Windows.Forms.Label();
            this.pnlDigits = new System.Windows.Forms.Panel();
            this.lblDigitsCountLabel = new System.Windows.Forms.Label();
            this.lblDigitsCount = new System.Windows.Forms.Label();
            this.lblDigits = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.pnlDigitsResults = new System.Windows.Forms.Panel();
            this.pnlDigitsResultsDisplay = new System.Windows.Forms.Panel();
            this.lblDigitsListEvens = new System.Windows.Forms.Label();
            this.lblDigitsListOdds = new System.Windows.Forms.Label();
            this.lblDigitsResultsLabel = new System.Windows.Forms.Label();
            this.tabTemperature = new System.Windows.Forms.TabPage();
            this.lblTemperatureTitle = new System.Windows.Forms.Label();
            this.pnlTemperature = new System.Windows.Forms.Panel();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.btnFahrenheit = new System.Windows.Forms.RadioButton();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.btnCelsius = new System.Windows.Forms.RadioButton();
            this.pnlTemperatureResults = new System.Windows.Forms.Panel();
            this.lblCelsiusDisplayLabel = new System.Windows.Forms.Label();
            this.lblFahrenheitDisplay = new System.Windows.Forms.Label();
            this.lblFahrenheitDisplayLabel = new System.Windows.Forms.Label();
            this.lblCelsiusDisplay = new System.Windows.Forms.Label();
            this.tabMyFavorites = new System.Windows.Forms.TabPage();
            this.lblFavoriteTitle = new System.Windows.Forms.Label();
            this.pnlFavoriteControls = new System.Windows.Forms.Panel();
            this.btnFavoriteFruit = new System.Windows.Forms.RadioButton();
            this.btnFavoriteActor = new System.Windows.Forms.RadioButton();
            this.btnFavoriteColor = new System.Windows.Forms.RadioButton();
            this.btnFavoriteHobby = new System.Windows.Forms.RadioButton();
            this.btnFavoriteMovie = new System.Windows.Forms.RadioButton();
            this.pnlFavoriteDisplay = new System.Windows.Forms.Panel();
            this.lblFavoriteInfo = new System.Windows.Forms.Label();
            this.pnlFavoriteImage = new System.Windows.Forms.Panel();
            this.tabRectangle = new System.Windows.Forms.TabPage();
            this.lblRectangleTitle = new System.Windows.Forms.Label();
            this.pnlRectangleControls = new System.Windows.Forms.Panel();
            this.lblRectanglePerimeter = new System.Windows.Forms.Label();
            this.lblRectangleArea = new System.Windows.Forms.Label();
            this.lblRectanglePerimiterTitle = new System.Windows.Forms.Label();
            this.lblRectangleDimensions = new System.Windows.Forms.Label();
            this.txtRectangleDimensions = new System.Windows.Forms.TextBox();
            this.lblRectangleAreaTitle = new System.Windows.Forms.Label();
            this.btnRectangleCalculate = new System.Windows.Forms.Button();
            this.pnlRectangleContainer = new System.Windows.Forms.Panel();
            this.pnlRectangle = new System.Windows.Forms.Panel();
            this.lblRectangleError = new System.Windows.Forms.Label();
            this.tabMySchool = new System.Windows.Forms.TabPage();
            this.lblMySchoolTitle = new System.Windows.Forms.Label();
            this.pnlMySchool = new System.Windows.Forms.Panel();
            this.btnMySchoolToggleMascot = new System.Windows.Forms.Button();
            this.picMySchoolMascot = new System.Windows.Forms.PictureBox();
            this.lblMySchoolMascot = new System.Windows.Forms.Label();
            this.tabHelloWorld = new System.Windows.Forms.TabPage();
            this.pnlHelloWorld = new System.Windows.Forms.Panel();
            this.btnHelloWorldReset = new System.Windows.Forms.Button();
            this.picHelloWorldFrench = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldGerman = new System.Windows.Forms.RadioButton();
            this.picHelloWorldEnglish = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldEnglish = new System.Windows.Forms.RadioButton();
            this.btnHelloWorldFrench = new System.Windows.Forms.RadioButton();
            this.picHelloWorldGerman = new System.Windows.Forms.PictureBox();
            this.lblHelloWorldTitle = new System.Windows.Forms.Label();
            this.tabMathre = new System.Windows.Forms.TabControl();
            this.mnuBaseLayer.SuspendLayout();
            this.tabSecret.SuspendLayout();
            this.pnlSecret.SuspendLayout();
            this.tabPizza.SuspendLayout();
            this.pnlPizza.SuspendLayout();
            this.pnlTip.SuspendLayout();
            this.pnlDiningType.SuspendLayout();
            this.pnlPizzaCost.SuspendLayout();
            this.tabChange.SuspendLayout();
            this.pnlChangeMaker.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabDigits.SuspendLayout();
            this.pnlDigits.SuspendLayout();
            this.pnlDigitsResults.SuspendLayout();
            this.pnlDigitsResultsDisplay.SuspendLayout();
            this.tabTemperature.SuspendLayout();
            this.pnlTemperature.SuspendLayout();
            this.pnlTemperatureResults.SuspendLayout();
            this.tabMyFavorites.SuspendLayout();
            this.pnlFavoriteControls.SuspendLayout();
            this.pnlFavoriteDisplay.SuspendLayout();
            this.tabRectangle.SuspendLayout();
            this.pnlRectangleControls.SuspendLayout();
            this.pnlRectangleContainer.SuspendLayout();
            this.tabMySchool.SuspendLayout();
            this.pnlMySchool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).BeginInit();
            this.tabHelloWorld.SuspendLayout();
            this.pnlHelloWorld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldFrench)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldGerman)).BeginInit();
            this.tabMathre.SuspendLayout();
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
            this.mnuBaseLayer.Size = new System.Drawing.Size(985, 24);
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
            this.mnuChange,
            this.mnuPizza,
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
            this.mnuFavoriteHobby,
            this.mnuFavoriteColor});
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
            // mnuFavoriteHobby
            // 
            this.mnuFavoriteHobby.Name = "mnuFavoriteHobby";
            this.mnuFavoriteHobby.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteHobby.Text = "Hobby";
            // 
            // mnuFavoriteColor
            // 
            this.mnuFavoriteColor.Name = "mnuFavoriteColor";
            this.mnuFavoriteColor.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteColor.Text = "Color";
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
            // mnuChange
            // 
            this.mnuChange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangeCalculate});
            this.mnuChange.Name = "mnuChange";
            this.mnuChange.Size = new System.Drawing.Size(195, 22);
            this.mnuChange.Text = "Change Maker";
            // 
            // mnuChangeCalculate
            // 
            this.mnuChangeCalculate.Name = "mnuChangeCalculate";
            this.mnuChangeCalculate.Size = new System.Drawing.Size(123, 22);
            this.mnuChangeCalculate.Text = "Calculate";
            // 
            // mnuPizza
            // 
            this.mnuPizza.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPizzaDelivery,
            this.mnuPizzaTakeout,
            this.mnuPizzaDollars,
            this.mnuPizzaPercent});
            this.mnuPizza.Name = "mnuPizza";
            this.mnuPizza.Size = new System.Drawing.Size(195, 22);
            this.mnuPizza.Text = "Pizza Delivery";
            // 
            // mnuPizzaTakeout
            // 
            this.mnuPizzaTakeout.Name = "mnuPizzaTakeout";
            this.mnuPizzaTakeout.Size = new System.Drawing.Size(180, 22);
            this.mnuPizzaTakeout.Text = "Takeout";
            // 
            // mnuPizzaDelivery
            // 
            this.mnuPizzaDelivery.Name = "mnuPizzaDelivery";
            this.mnuPizzaDelivery.Size = new System.Drawing.Size(180, 22);
            this.mnuPizzaDelivery.Text = "Delivery";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(195, 22);
            this.mnuExit.Text = "Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Enabled = false;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 24);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 24);
            this.mnuView.Text = "View";
            // 
            // imgFavoriteImages
            // 
            this.imgFavoriteImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFavoriteImages.ImageStream")));
            this.imgFavoriteImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFavoriteImages.Images.SetKeyName(0, "Actor.jpg");
            this.imgFavoriteImages.Images.SetKeyName(1, "Fruit.jpg");
            this.imgFavoriteImages.Images.SetKeyName(2, "Hobby.jpg");
            this.imgFavoriteImages.Images.SetKeyName(3, "Movie.jpg");
            this.imgFavoriteImages.Images.SetKeyName(4, "LargePizza.png");
            this.imgFavoriteImages.Images.SetKeyName(5, "MediumPizza.png");
            this.imgFavoriteImages.Images.SetKeyName(6, "SmallPizza.png");
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
            // mnuPizzaDollars
            // 
            this.mnuPizzaDollars.Name = "mnuPizzaDollars";
            this.mnuPizzaDollars.Size = new System.Drawing.Size(180, 22);
            this.mnuPizzaDollars.Text = "Dollars";
            // 
            // mnuPizzaPercent
            // 
            this.mnuPizzaPercent.Name = "mnuPizzaPercent";
            this.mnuPizzaPercent.Size = new System.Drawing.Size(180, 22);
            this.mnuPizzaPercent.Text = "Percent";
            // 
            // tabSecret
            // 
            this.tabSecret.Controls.Add(this.pnlSecret);
            this.tabSecret.Controls.Add(this.lblSecretTitle);
            this.tabSecret.Location = new System.Drawing.Point(4, 22);
            this.tabSecret.Name = "tabSecret";
            this.tabSecret.Size = new System.Drawing.Size(982, 448);
            this.tabSecret.TabIndex = 3;
            this.tabSecret.Text = "Secret Settings Page";
            this.tabSecret.UseVisualStyleBackColor = true;
            // 
            // lblSecretTitle
            // 
            this.lblSecretTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecretTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretTitle.Location = new System.Drawing.Point(178, 73);
            this.lblSecretTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblSecretTitle.Name = "lblSecretTitle";
            this.lblSecretTitle.Size = new System.Drawing.Size(626, 51);
            this.lblSecretTitle.TabIndex = 9;
            this.lblSecretTitle.Text = "Enable Super Secret Settings";
            this.lblSecretTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSecret
            // 
            this.pnlSecret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSecret.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSecret.Controls.Add(this.btnSecretDisable);
            this.pnlSecret.Controls.Add(this.lblSecretPrompt);
            this.pnlSecret.Controls.Add(this.btnSecretEnable);
            this.pnlSecret.Controls.Add(this.txtSecretPassword);
            this.pnlSecret.Location = new System.Drawing.Point(278, 137);
            this.pnlSecret.Name = "pnlSecret";
            this.pnlSecret.Size = new System.Drawing.Size(426, 105);
            this.pnlSecret.TabIndex = 22;
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
            // tabUnknown
            // 
            this.tabUnknown.Location = new System.Drawing.Point(4, 22);
            this.tabUnknown.Name = "tabUnknown";
            this.tabUnknown.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnknown.Size = new System.Drawing.Size(982, 448);
            this.tabUnknown.TabIndex = 2;
            this.tabUnknown.Text = "...";
            this.tabUnknown.UseVisualStyleBackColor = true;
            // 
            // tabPizza
            // 
            this.tabPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPizza.Controls.Add(this.pnlPizzaCost);
            this.tabPizza.Controls.Add(this.pnlPizza);
            this.tabPizza.Controls.Add(this.lblPizzaTitle);
            this.tabPizza.Location = new System.Drawing.Point(4, 22);
            this.tabPizza.Name = "tabPizza";
            this.tabPizza.Size = new System.Drawing.Size(982, 448);
            this.tabPizza.TabIndex = 9;
            this.tabPizza.Tag = "Transparent";
            this.tabPizza.Text = "Pizza Delivery";
            this.tabPizza.UseVisualStyleBackColor = true;
            // 
            // lblPizzaTitle
            // 
            this.lblPizzaTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPizzaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaTitle.Location = new System.Drawing.Point(178, 68);
            this.lblPizzaTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblPizzaTitle.Name = "lblPizzaTitle";
            this.lblPizzaTitle.Size = new System.Drawing.Size(626, 51);
            this.lblPizzaTitle.TabIndex = 23;
            this.lblPizzaTitle.Text = "Pizza Delivery";
            this.lblPizzaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPizza
            // 
            this.pnlPizza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPizza.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPizza.Controls.Add(this.pnlDiningType);
            this.pnlPizza.Controls.Add(this.lblPizzaSize);
            this.pnlPizza.Controls.Add(this.txtPizzaTip);
            this.pnlPizza.Controls.Add(this.pnlTip);
            this.pnlPizza.Controls.Add(this.lblPizzaTip);
            this.pnlPizza.Controls.Add(this.txtPizzaSize);
            this.pnlPizza.Location = new System.Drawing.Point(278, 137);
            this.pnlPizza.Name = "pnlPizza";
            this.pnlPizza.Size = new System.Drawing.Size(426, 105);
            this.pnlPizza.TabIndex = 26;
            // 
            // txtPizzaSize
            // 
            this.txtPizzaSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtPizzaSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPizzaSize.Location = new System.Drawing.Point(127, 13);
            this.txtPizzaSize.Margin = new System.Windows.Forms.Padding(0);
            this.txtPizzaSize.Name = "txtPizzaSize";
            this.txtPizzaSize.Size = new System.Drawing.Size(90, 26);
            this.txtPizzaSize.TabIndex = 13;
            // 
            // lblPizzaTip
            // 
            this.lblPizzaTip.AutoSize = true;
            this.lblPizzaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaTip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPizzaTip.Location = new System.Drawing.Point(18, 64);
            this.lblPizzaTip.Name = "lblPizzaTip";
            this.lblPizzaTip.Size = new System.Drawing.Size(34, 20);
            this.lblPizzaTip.TabIndex = 27;
            this.lblPizzaTip.Text = "Tip:";
            // 
            // pnlTip
            // 
            this.pnlTip.Controls.Add(this.btnPercent);
            this.pnlTip.Controls.Add(this.btnDollars);
            this.pnlTip.Location = new System.Drawing.Point(220, 60);
            this.pnlTip.Name = "pnlTip";
            this.pnlTip.Size = new System.Drawing.Size(199, 24);
            this.pnlTip.TabIndex = 27;
            this.pnlTip.Tag = "Transparent";
            // 
            // btnDollars
            // 
            this.btnDollars.AutoSize = true;
            this.btnDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDollars.Location = new System.Drawing.Point(8, 3);
            this.btnDollars.Name = "btnDollars";
            this.btnDollars.Size = new System.Drawing.Size(76, 24);
            this.btnDollars.TabIndex = 31;
            this.btnDollars.Text = "Dollars";
            this.btnDollars.UseVisualStyleBackColor = true;
            // 
            // btnPercent
            // 
            this.btnPercent.AutoSize = true;
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.Location = new System.Drawing.Point(109, 3);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(82, 24);
            this.btnPercent.TabIndex = 32;
            this.btnPercent.Text = "Percent";
            this.btnPercent.UseVisualStyleBackColor = true;
            // 
            // txtPizzaTip
            // 
            this.txtPizzaTip.BackColor = System.Drawing.SystemColors.Window;
            this.txtPizzaTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPizzaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPizzaTip.Location = new System.Drawing.Point(55, 61);
            this.txtPizzaTip.Margin = new System.Windows.Forms.Padding(0);
            this.txtPizzaTip.Name = "txtPizzaTip";
            this.txtPizzaTip.Size = new System.Drawing.Size(162, 26);
            this.txtPizzaTip.TabIndex = 30;
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPizzaSize.Location = new System.Drawing.Point(18, 16);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(106, 20);
            this.lblPizzaSize.TabIndex = 9;
            this.lblPizzaSize.Text = "Size (Inches):";
            // 
            // pnlDiningType
            // 
            this.pnlDiningType.Controls.Add(this.btnTakeout);
            this.pnlDiningType.Controls.Add(this.btnDelivery);
            this.pnlDiningType.Location = new System.Drawing.Point(220, 12);
            this.pnlDiningType.Name = "pnlDiningType";
            this.pnlDiningType.Size = new System.Drawing.Size(199, 24);
            this.pnlDiningType.TabIndex = 33;
            this.pnlDiningType.Tag = "Transparent";
            // 
            // btnDelivery
            // 
            this.btnDelivery.AutoSize = true;
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.Location = new System.Drawing.Point(109, 4);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(82, 24);
            this.btnDelivery.TabIndex = 26;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            // 
            // btnTakeout
            // 
            this.btnTakeout.AutoSize = true;
            this.btnTakeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeout.Location = new System.Drawing.Point(8, 3);
            this.btnTakeout.Name = "btnTakeout";
            this.btnTakeout.Size = new System.Drawing.Size(85, 24);
            this.btnTakeout.TabIndex = 25;
            this.btnTakeout.Text = "Takeout";
            this.btnTakeout.UseVisualStyleBackColor = true;
            // 
            // pnlPizzaCost
            // 
            this.pnlPizzaCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPizzaCost.BackColor = System.Drawing.Color.Transparent;
            this.pnlPizzaCost.Controls.Add(this.pnlPizzaViewer);
            this.pnlPizzaCost.Controls.Add(this.lblPizzaCostAmount);
            this.pnlPizzaCost.Controls.Add(this.lblPizzaCost);
            this.pnlPizzaCost.Location = new System.Drawing.Point(278, 258);
            this.pnlPizzaCost.Name = "pnlPizzaCost";
            this.pnlPizzaCost.Size = new System.Drawing.Size(426, 81);
            this.pnlPizzaCost.TabIndex = 28;
            // 
            // lblPizzaCost
            // 
            this.lblPizzaCost.AutoSize = true;
            this.lblPizzaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaCost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPizzaCost.Location = new System.Drawing.Point(18, 30);
            this.lblPizzaCost.Name = "lblPizzaCost";
            this.lblPizzaCost.Size = new System.Drawing.Size(46, 20);
            this.lblPizzaCost.TabIndex = 14;
            this.lblPizzaCost.Text = "Cost:";
            // 
            // lblPizzaCostAmount
            // 
            this.lblPizzaCostAmount.AutoSize = true;
            this.lblPizzaCostAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaCostAmount.Location = new System.Drawing.Point(70, 33);
            this.lblPizzaCostAmount.Name = "lblPizzaCostAmount";
            this.lblPizzaCostAmount.Size = new System.Drawing.Size(137, 15);
            this.lblPizzaCostAmount.TabIndex = 16;
            this.lblPizzaCostAmount.Text = "Not Enough Information";
            this.lblPizzaCostAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPizzaViewer
            // 
            this.pnlPizzaViewer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPizzaViewer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPizzaViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPizzaViewer.Location = new System.Drawing.Point(348, 3);
            this.pnlPizzaViewer.Name = "pnlPizzaViewer";
            this.pnlPizzaViewer.Size = new System.Drawing.Size(75, 75);
            this.pnlPizzaViewer.TabIndex = 29;
            // 
            // tabChange
            // 
            this.tabChange.Controls.Add(this.panel3);
            this.tabChange.Controls.Add(this.pnlChangeMaker);
            this.tabChange.Controls.Add(this.lblChangeMakerTitle);
            this.tabChange.Location = new System.Drawing.Point(4, 22);
            this.tabChange.Name = "tabChange";
            this.tabChange.Size = new System.Drawing.Size(982, 448);
            this.tabChange.TabIndex = 8;
            this.tabChange.Text = "Change Maker";
            this.tabChange.UseVisualStyleBackColor = true;
            // 
            // lblChangeMakerTitle
            // 
            this.lblChangeMakerTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChangeMakerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeMakerTitle.Location = new System.Drawing.Point(178, 68);
            this.lblChangeMakerTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblChangeMakerTitle.Name = "lblChangeMakerTitle";
            this.lblChangeMakerTitle.Size = new System.Drawing.Size(626, 51);
            this.lblChangeMakerTitle.TabIndex = 20;
            this.lblChangeMakerTitle.Text = "Change Maker";
            this.lblChangeMakerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChangeMaker
            // 
            this.pnlChangeMaker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChangeMaker.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChangeMaker.Controls.Add(this.txtPaidAmount);
            this.pnlChangeMaker.Controls.Add(this.lblPaidAmount);
            this.pnlChangeMaker.Location = new System.Drawing.Point(278, 137);
            this.pnlChangeMaker.Name = "pnlChangeMaker";
            this.pnlChangeMaker.Size = new System.Drawing.Size(426, 105);
            this.pnlChangeMaker.TabIndex = 22;
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPaidAmount.Location = new System.Drawing.Point(18, 16);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(104, 20);
            this.lblPaidAmount.TabIndex = 9;
            this.lblPaidAmount.Text = "Paid Amount:";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(125, 13);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(0);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(292, 26);
            this.txtPaidAmount.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblOnesCount);
            this.panel3.Controls.Add(this.lblHundreds);
            this.panel3.Controls.Add(this.lblQuartersCount);
            this.panel3.Controls.Add(this.lblChange);
            this.panel3.Controls.Add(this.lblDimesCount);
            this.panel3.Controls.Add(this.lblHundredsCount);
            this.panel3.Controls.Add(this.lblNickelsCount);
            this.panel3.Controls.Add(this.lblFifties);
            this.panel3.Controls.Add(this.lblPenniesCount);
            this.panel3.Controls.Add(this.lblTwenties);
            this.panel3.Controls.Add(this.lblFivesCount);
            this.panel3.Controls.Add(this.lblTens);
            this.panel3.Controls.Add(this.lblTensCount);
            this.panel3.Controls.Add(this.lblFives);
            this.panel3.Controls.Add(this.lblTwentiesCount);
            this.panel3.Controls.Add(this.lblOnes);
            this.panel3.Controls.Add(this.lblFiftiesCount);
            this.panel3.Controls.Add(this.lblQuarters);
            this.panel3.Controls.Add(this.lblPennies);
            this.panel3.Controls.Add(this.lblDimes);
            this.panel3.Controls.Add(this.lblNickels);
            this.panel3.Location = new System.Drawing.Point(278, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 136);
            this.panel3.TabIndex = 28;
            // 
            // lblNickels
            // 
            this.lblNickels.AutoSize = true;
            this.lblNickels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickels.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNickels.Location = new System.Drawing.Point(266, 83);
            this.lblNickels.Name = "lblNickels";
            this.lblNickels.Size = new System.Drawing.Size(63, 20);
            this.lblNickels.TabIndex = 25;
            this.lblNickels.Text = "Nickels:";
            // 
            // lblDimes
            // 
            this.lblDimes.AutoSize = true;
            this.lblDimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDimes.Location = new System.Drawing.Point(266, 57);
            this.lblDimes.Name = "lblDimes";
            this.lblDimes.Size = new System.Drawing.Size(58, 20);
            this.lblDimes.TabIndex = 24;
            this.lblDimes.Text = "Dimes:";
            // 
            // lblPennies
            // 
            this.lblPennies.AutoSize = true;
            this.lblPennies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPennies.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPennies.Location = new System.Drawing.Point(266, 109);
            this.lblPennies.Name = "lblPennies";
            this.lblPennies.Size = new System.Drawing.Size(70, 20);
            this.lblPennies.TabIndex = 26;
            this.lblPennies.Text = "Pennies:";
            // 
            // lblQuarters
            // 
            this.lblQuarters.AutoSize = true;
            this.lblQuarters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuarters.Location = new System.Drawing.Point(266, 31);
            this.lblQuarters.Name = "lblQuarters";
            this.lblQuarters.Size = new System.Drawing.Size(75, 20);
            this.lblQuarters.TabIndex = 23;
            this.lblQuarters.Text = "Quarters:";
            // 
            // lblFiftiesCount
            // 
            this.lblFiftiesCount.AutoSize = true;
            this.lblFiftiesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiftiesCount.Location = new System.Drawing.Point(163, 34);
            this.lblFiftiesCount.Name = "lblFiftiesCount";
            this.lblFiftiesCount.Size = new System.Drawing.Size(14, 15);
            this.lblFiftiesCount.TabIndex = 27;
            this.lblFiftiesCount.Text = "0";
            this.lblFiftiesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOnes
            // 
            this.lblOnes.AutoSize = true;
            this.lblOnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOnes.Location = new System.Drawing.Point(266, 5);
            this.lblOnes.Name = "lblOnes";
            this.lblOnes.Size = new System.Drawing.Size(51, 20);
            this.lblOnes.TabIndex = 22;
            this.lblOnes.Text = "Ones:";
            // 
            // lblTwentiesCount
            // 
            this.lblTwentiesCount.AutoSize = true;
            this.lblTwentiesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwentiesCount.Location = new System.Drawing.Point(183, 60);
            this.lblTwentiesCount.Name = "lblTwentiesCount";
            this.lblTwentiesCount.Size = new System.Drawing.Size(14, 15);
            this.lblTwentiesCount.TabIndex = 28;
            this.lblTwentiesCount.Text = "0";
            this.lblTwentiesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFives
            // 
            this.lblFives.AutoSize = true;
            this.lblFives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFives.Location = new System.Drawing.Point(101, 109);
            this.lblFives.Name = "lblFives";
            this.lblFives.Size = new System.Drawing.Size(50, 20);
            this.lblFives.TabIndex = 21;
            this.lblFives.Text = "Fives:";
            // 
            // lblTensCount
            // 
            this.lblTensCount.AutoSize = true;
            this.lblTensCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensCount.Location = new System.Drawing.Point(155, 86);
            this.lblTensCount.Name = "lblTensCount";
            this.lblTensCount.Size = new System.Drawing.Size(14, 15);
            this.lblTensCount.TabIndex = 29;
            this.lblTensCount.Text = "0";
            this.lblTensCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTens
            // 
            this.lblTens.AutoSize = true;
            this.lblTens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTens.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTens.Location = new System.Drawing.Point(101, 83);
            this.lblTens.Name = "lblTens";
            this.lblTens.Size = new System.Drawing.Size(48, 20);
            this.lblTens.TabIndex = 20;
            this.lblTens.Text = "Tens:";
            // 
            // lblFivesCount
            // 
            this.lblFivesCount.AutoSize = true;
            this.lblFivesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFivesCount.Location = new System.Drawing.Point(157, 112);
            this.lblFivesCount.Name = "lblFivesCount";
            this.lblFivesCount.Size = new System.Drawing.Size(14, 15);
            this.lblFivesCount.TabIndex = 30;
            this.lblFivesCount.Text = "0";
            this.lblFivesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTwenties
            // 
            this.lblTwenties.AutoSize = true;
            this.lblTwenties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwenties.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTwenties.Location = new System.Drawing.Point(101, 57);
            this.lblTwenties.Name = "lblTwenties";
            this.lblTwenties.Size = new System.Drawing.Size(76, 20);
            this.lblTwenties.TabIndex = 19;
            this.lblTwenties.Text = "Twenties:";
            // 
            // lblPenniesCount
            // 
            this.lblPenniesCount.AutoSize = true;
            this.lblPenniesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenniesCount.Location = new System.Drawing.Point(342, 112);
            this.lblPenniesCount.Name = "lblPenniesCount";
            this.lblPenniesCount.Size = new System.Drawing.Size(14, 15);
            this.lblPenniesCount.TabIndex = 31;
            this.lblPenniesCount.Text = "0";
            this.lblPenniesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFifties
            // 
            this.lblFifties.AutoSize = true;
            this.lblFifties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFifties.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFifties.Location = new System.Drawing.Point(101, 31);
            this.lblFifties.Name = "lblFifties";
            this.lblFifties.Size = new System.Drawing.Size(56, 20);
            this.lblFifties.TabIndex = 18;
            this.lblFifties.Text = "Fifties:";
            // 
            // lblNickelsCount
            // 
            this.lblNickelsCount.AutoSize = true;
            this.lblNickelsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickelsCount.Location = new System.Drawing.Point(335, 86);
            this.lblNickelsCount.Name = "lblNickelsCount";
            this.lblNickelsCount.Size = new System.Drawing.Size(14, 15);
            this.lblNickelsCount.TabIndex = 32;
            this.lblNickelsCount.Text = "0";
            this.lblNickelsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHundredsCount
            // 
            this.lblHundredsCount.AutoSize = true;
            this.lblHundredsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHundredsCount.Location = new System.Drawing.Point(190, 8);
            this.lblHundredsCount.Name = "lblHundredsCount";
            this.lblHundredsCount.Size = new System.Drawing.Size(14, 15);
            this.lblHundredsCount.TabIndex = 16;
            this.lblHundredsCount.Text = "0";
            this.lblHundredsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDimesCount
            // 
            this.lblDimesCount.AutoSize = true;
            this.lblDimesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimesCount.Location = new System.Drawing.Point(330, 60);
            this.lblDimesCount.Name = "lblDimesCount";
            this.lblDimesCount.Size = new System.Drawing.Size(14, 15);
            this.lblDimesCount.TabIndex = 33;
            this.lblDimesCount.Text = "0";
            this.lblDimesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChange.Location = new System.Drawing.Point(5, 5);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(69, 20);
            this.lblChange.TabIndex = 14;
            this.lblChange.Text = "Change:";
            // 
            // lblQuartersCount
            // 
            this.lblQuartersCount.AutoSize = true;
            this.lblQuartersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuartersCount.Location = new System.Drawing.Point(347, 34);
            this.lblQuartersCount.Name = "lblQuartersCount";
            this.lblQuartersCount.Size = new System.Drawing.Size(14, 15);
            this.lblQuartersCount.TabIndex = 34;
            this.lblQuartersCount.Text = "0";
            this.lblQuartersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHundreds
            // 
            this.lblHundreds.AutoSize = true;
            this.lblHundreds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHundreds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHundreds.Location = new System.Drawing.Point(101, 5);
            this.lblHundreds.Name = "lblHundreds";
            this.lblHundreds.Size = new System.Drawing.Size(83, 20);
            this.lblHundreds.TabIndex = 15;
            this.lblHundreds.Text = "Hundreds:";
            // 
            // lblOnesCount
            // 
            this.lblOnesCount.AutoSize = true;
            this.lblOnesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnesCount.Location = new System.Drawing.Point(323, 8);
            this.lblOnesCount.Name = "lblOnesCount";
            this.lblOnesCount.Size = new System.Drawing.Size(14, 15);
            this.lblOnesCount.TabIndex = 35;
            this.lblOnesCount.Text = "0";
            this.lblOnesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabDigits
            // 
            this.tabDigits.Controls.Add(this.pnlDigitsResults);
            this.tabDigits.Controls.Add(this.pnlDigits);
            this.tabDigits.Controls.Add(this.lblDigitsTitle);
            this.tabDigits.Location = new System.Drawing.Point(4, 22);
            this.tabDigits.Name = "tabDigits";
            this.tabDigits.Size = new System.Drawing.Size(982, 448);
            this.tabDigits.TabIndex = 7;
            this.tabDigits.Text = "Digit Separator";
            this.tabDigits.UseVisualStyleBackColor = true;
            // 
            // lblDigitsTitle
            // 
            this.lblDigitsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDigitsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitsTitle.Location = new System.Drawing.Point(178, 68);
            this.lblDigitsTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblDigitsTitle.Name = "lblDigitsTitle";
            this.lblDigitsTitle.Size = new System.Drawing.Size(626, 51);
            this.lblDigitsTitle.TabIndex = 20;
            this.lblDigitsTitle.Text = "Numerical Digit Separator";
            this.lblDigitsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDigits
            // 
            this.pnlDigits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDigits.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDigits.Controls.Add(this.txtNumber);
            this.pnlDigits.Controls.Add(this.lblDigits);
            this.pnlDigits.Controls.Add(this.lblDigitsCount);
            this.pnlDigits.Controls.Add(this.lblDigitsCountLabel);
            this.pnlDigits.Location = new System.Drawing.Point(278, 137);
            this.pnlDigits.Name = "pnlDigits";
            this.pnlDigits.Size = new System.Drawing.Size(426, 105);
            this.pnlDigits.TabIndex = 22;
            // 
            // lblDigitsCountLabel
            // 
            this.lblDigitsCountLabel.AutoSize = true;
            this.lblDigitsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitsCountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDigitsCountLabel.Location = new System.Drawing.Point(18, 61);
            this.lblDigitsCountLabel.Name = "lblDigitsCountLabel";
            this.lblDigitsCountLabel.Size = new System.Drawing.Size(131, 20);
            this.lblDigitsCountLabel.TabIndex = 20;
            this.lblDigitsCountLabel.Text = "Number of Digits:";
            // 
            // lblDigitsCount
            // 
            this.lblDigitsCount.AutoSize = true;
            this.lblDigitsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitsCount.Location = new System.Drawing.Point(155, 64);
            this.lblDigitsCount.Name = "lblDigitsCount";
            this.lblDigitsCount.Size = new System.Drawing.Size(38, 15);
            this.lblDigitsCount.TabIndex = 21;
            this.lblDigitsCount.Text = "Digits";
            this.lblDigitsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDigits.Location = new System.Drawing.Point(18, 16);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(69, 20);
            this.lblDigits.TabIndex = 18;
            this.lblDigits.Text = "Number:";
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
            this.txtNumber.TabIndex = 19;
            // 
            // pnlDigitsResults
            // 
            this.pnlDigitsResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDigitsResults.BackColor = System.Drawing.Color.Transparent;
            this.pnlDigitsResults.Controls.Add(this.pnlDigitsResultsDisplay);
            this.pnlDigitsResults.Location = new System.Drawing.Point(278, 258);
            this.pnlDigitsResults.Name = "pnlDigitsResults";
            this.pnlDigitsResults.Size = new System.Drawing.Size(426, 136);
            this.pnlDigitsResults.TabIndex = 28;
            // 
            // pnlDigitsResultsDisplay
            // 
            this.pnlDigitsResultsDisplay.AutoScroll = true;
            this.pnlDigitsResultsDisplay.Controls.Add(this.lblDigitsResultsLabel);
            this.pnlDigitsResultsDisplay.Controls.Add(this.lblDigitsListOdds);
            this.pnlDigitsResultsDisplay.Controls.Add(this.lblDigitsListEvens);
            this.pnlDigitsResultsDisplay.Location = new System.Drawing.Point(2, 2);
            this.pnlDigitsResultsDisplay.Name = "pnlDigitsResultsDisplay";
            this.pnlDigitsResultsDisplay.Size = new System.Drawing.Size(422, 132);
            this.pnlDigitsResultsDisplay.TabIndex = 22;
            this.pnlDigitsResultsDisplay.Tag = "Transparent";
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
            // lblDigitsListOdds
            // 
            this.lblDigitsListOdds.AutoSize = true;
            this.lblDigitsListOdds.Location = new System.Drawing.Point(124, 45);
            this.lblDigitsListOdds.Name = "lblDigitsListOdds";
            this.lblDigitsListOdds.Size = new System.Drawing.Size(51, 13);
            this.lblDigitsListOdds.TabIndex = 2;
            this.lblDigitsListOdds.Text = "Digit #: #";
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
            // tabTemperature
            // 
            this.tabTemperature.Controls.Add(this.pnlTemperatureResults);
            this.tabTemperature.Controls.Add(this.pnlTemperature);
            this.tabTemperature.Controls.Add(this.lblTemperatureTitle);
            this.tabTemperature.Location = new System.Drawing.Point(4, 22);
            this.tabTemperature.Name = "tabTemperature";
            this.tabTemperature.Size = new System.Drawing.Size(982, 448);
            this.tabTemperature.TabIndex = 6;
            this.tabTemperature.Text = "Temperature Converter";
            this.tabTemperature.UseVisualStyleBackColor = true;
            // 
            // lblTemperatureTitle
            // 
            this.lblTemperatureTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTemperatureTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureTitle.Location = new System.Drawing.Point(178, 68);
            this.lblTemperatureTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemperatureTitle.Name = "lblTemperatureTitle";
            this.lblTemperatureTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTemperatureTitle.TabIndex = 17;
            this.lblTemperatureTitle.Text = "Temperature Converter";
            this.lblTemperatureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTemperature
            // 
            this.pnlTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTemperature.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTemperature.Controls.Add(this.btnCelsius);
            this.pnlTemperature.Controls.Add(this.txtTemperature);
            this.pnlTemperature.Controls.Add(this.btnFahrenheit);
            this.pnlTemperature.Controls.Add(this.lblTemperature);
            this.pnlTemperature.Location = new System.Drawing.Point(278, 137);
            this.pnlTemperature.Name = "pnlTemperature";
            this.pnlTemperature.Size = new System.Drawing.Size(426, 105);
            this.pnlTemperature.TabIndex = 21;
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
            // pnlTemperatureResults
            // 
            this.pnlTemperatureResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTemperatureResults.BackColor = System.Drawing.Color.Transparent;
            this.pnlTemperatureResults.Controls.Add(this.lblCelsiusDisplay);
            this.pnlTemperatureResults.Controls.Add(this.lblFahrenheitDisplayLabel);
            this.pnlTemperatureResults.Controls.Add(this.lblFahrenheitDisplay);
            this.pnlTemperatureResults.Controls.Add(this.lblCelsiusDisplayLabel);
            this.pnlTemperatureResults.Location = new System.Drawing.Point(278, 258);
            this.pnlTemperatureResults.Name = "pnlTemperatureResults";
            this.pnlTemperatureResults.Size = new System.Drawing.Size(426, 81);
            this.pnlTemperatureResults.TabIndex = 27;
            // 
            // lblCelsiusDisplayLabel
            // 
            this.lblCelsiusDisplayLabel.AutoSize = true;
            this.lblCelsiusDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsiusDisplayLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCelsiusDisplayLabel.Location = new System.Drawing.Point(18, 43);
            this.lblCelsiusDisplayLabel.Name = "lblCelsiusDisplayLabel";
            this.lblCelsiusDisplayLabel.Size = new System.Drawing.Size(175, 20);
            this.lblCelsiusDisplayLabel.TabIndex = 15;
            this.lblCelsiusDisplayLabel.Text = "Temperature in Celsius:";
            // 
            // lblFahrenheitDisplay
            // 
            this.lblFahrenheitDisplay.AutoSize = true;
            this.lblFahrenheitDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheitDisplay.Location = new System.Drawing.Point(225, 20);
            this.lblFahrenheitDisplay.Name = "lblFahrenheitDisplay";
            this.lblFahrenheitDisplay.Size = new System.Drawing.Size(78, 15);
            this.lblFahrenheitDisplay.TabIndex = 16;
            this.lblFahrenheitDisplay.Text = "Temperature";
            this.lblFahrenheitDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFahrenheitDisplayLabel
            // 
            this.lblFahrenheitDisplayLabel.AutoSize = true;
            this.lblFahrenheitDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheitDisplayLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFahrenheitDisplayLabel.Location = new System.Drawing.Point(18, 17);
            this.lblFahrenheitDisplayLabel.Name = "lblFahrenheitDisplayLabel";
            this.lblFahrenheitDisplayLabel.Size = new System.Drawing.Size(201, 20);
            this.lblFahrenheitDisplayLabel.TabIndex = 14;
            this.lblFahrenheitDisplayLabel.Text = "Temperature in Fahrenheit:";
            // 
            // lblCelsiusDisplay
            // 
            this.lblCelsiusDisplay.AutoSize = true;
            this.lblCelsiusDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsiusDisplay.Location = new System.Drawing.Point(199, 46);
            this.lblCelsiusDisplay.Name = "lblCelsiusDisplay";
            this.lblCelsiusDisplay.Size = new System.Drawing.Size(78, 15);
            this.lblCelsiusDisplay.TabIndex = 17;
            this.lblCelsiusDisplay.Text = "Temperature";
            this.lblCelsiusDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabMyFavorites
            // 
            this.tabMyFavorites.Controls.Add(this.pnlFavoriteDisplay);
            this.tabMyFavorites.Controls.Add(this.pnlFavoriteControls);
            this.tabMyFavorites.Controls.Add(this.lblFavoriteTitle);
            this.tabMyFavorites.Location = new System.Drawing.Point(4, 22);
            this.tabMyFavorites.Name = "tabMyFavorites";
            this.tabMyFavorites.Size = new System.Drawing.Size(982, 448);
            this.tabMyFavorites.TabIndex = 5;
            this.tabMyFavorites.Text = "My Favorites";
            this.tabMyFavorites.UseVisualStyleBackColor = true;
            // 
            // lblFavoriteTitle
            // 
            this.lblFavoriteTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFavoriteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoriteTitle.Location = new System.Drawing.Point(178, 68);
            this.lblFavoriteTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblFavoriteTitle.Name = "lblFavoriteTitle";
            this.lblFavoriteTitle.Size = new System.Drawing.Size(626, 51);
            this.lblFavoriteTitle.TabIndex = 17;
            this.lblFavoriteTitle.Text = "My Favorite __________";
            this.lblFavoriteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFavoriteControls
            // 
            this.pnlFavoriteControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFavoriteControls.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFavoriteControls.Controls.Add(this.btnFavoriteMovie);
            this.pnlFavoriteControls.Controls.Add(this.btnFavoriteHobby);
            this.pnlFavoriteControls.Controls.Add(this.btnFavoriteColor);
            this.pnlFavoriteControls.Controls.Add(this.btnFavoriteActor);
            this.pnlFavoriteControls.Controls.Add(this.btnFavoriteFruit);
            this.pnlFavoriteControls.Location = new System.Drawing.Point(278, 137);
            this.pnlFavoriteControls.Name = "pnlFavoriteControls";
            this.pnlFavoriteControls.Size = new System.Drawing.Size(426, 105);
            this.pnlFavoriteControls.TabIndex = 20;
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
            // pnlFavoriteDisplay
            // 
            this.pnlFavoriteDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFavoriteDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlFavoriteDisplay.Controls.Add(this.pnlFavoriteImage);
            this.pnlFavoriteDisplay.Controls.Add(this.lblFavoriteInfo);
            this.pnlFavoriteDisplay.Location = new System.Drawing.Point(278, 258);
            this.pnlFavoriteDisplay.Name = "pnlFavoriteDisplay";
            this.pnlFavoriteDisplay.Size = new System.Drawing.Size(426, 136);
            this.pnlFavoriteDisplay.TabIndex = 25;
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
            // pnlFavoriteImage
            // 
            this.pnlFavoriteImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFavoriteImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlFavoriteImage.Location = new System.Drawing.Point(19, 18);
            this.pnlFavoriteImage.Name = "pnlFavoriteImage";
            this.pnlFavoriteImage.Size = new System.Drawing.Size(100, 100);
            this.pnlFavoriteImage.TabIndex = 26;
            // 
            // tabRectangle
            // 
            this.tabRectangle.Controls.Add(this.pnlRectangleContainer);
            this.tabRectangle.Controls.Add(this.pnlRectangleControls);
            this.tabRectangle.Controls.Add(this.lblRectangleTitle);
            this.tabRectangle.Location = new System.Drawing.Point(4, 22);
            this.tabRectangle.Name = "tabRectangle";
            this.tabRectangle.Size = new System.Drawing.Size(982, 448);
            this.tabRectangle.TabIndex = 4;
            this.tabRectangle.Text = "Rectangle Calculator";
            this.tabRectangle.UseVisualStyleBackColor = true;
            // 
            // lblRectangleTitle
            // 
            this.lblRectangleTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRectangleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleTitle.Location = new System.Drawing.Point(178, 68);
            this.lblRectangleTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblRectangleTitle.Name = "lblRectangleTitle";
            this.lblRectangleTitle.Size = new System.Drawing.Size(626, 51);
            this.lblRectangleTitle.TabIndex = 11;
            this.lblRectangleTitle.Text = "Rectangle Calculator";
            this.lblRectangleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRectangleControls
            // 
            this.pnlRectangleControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRectangleControls.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRectangleControls.Controls.Add(this.btnRectangleCalculate);
            this.pnlRectangleControls.Controls.Add(this.lblRectangleAreaTitle);
            this.pnlRectangleControls.Controls.Add(this.txtRectangleDimensions);
            this.pnlRectangleControls.Controls.Add(this.lblRectangleDimensions);
            this.pnlRectangleControls.Controls.Add(this.lblRectanglePerimiterTitle);
            this.pnlRectangleControls.Controls.Add(this.lblRectangleArea);
            this.pnlRectangleControls.Controls.Add(this.lblRectanglePerimeter);
            this.pnlRectangleControls.Location = new System.Drawing.Point(278, 137);
            this.pnlRectangleControls.Name = "pnlRectangleControls";
            this.pnlRectangleControls.Size = new System.Drawing.Size(426, 105);
            this.pnlRectangleControls.TabIndex = 16;
            // 
            // lblRectanglePerimeter
            // 
            this.lblRectanglePerimeter.AutoSize = true;
            this.lblRectanglePerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectanglePerimeter.Location = new System.Drawing.Point(99, 71);
            this.lblRectanglePerimeter.Name = "lblRectanglePerimeter";
            this.lblRectanglePerimeter.Size = new System.Drawing.Size(61, 15);
            this.lblRectanglePerimeter.TabIndex = 24;
            this.lblRectanglePerimeter.Text = "Perimeter";
            this.lblRectanglePerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRectangleArea
            // 
            this.lblRectangleArea.AutoSize = true;
            this.lblRectangleArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleArea.Location = new System.Drawing.Point(71, 45);
            this.lblRectangleArea.Name = "lblRectangleArea";
            this.lblRectangleArea.Size = new System.Drawing.Size(32, 15);
            this.lblRectangleArea.TabIndex = 23;
            this.lblRectangleArea.Text = "Area";
            this.lblRectangleArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRectanglePerimiterTitle
            // 
            this.lblRectanglePerimiterTitle.AutoSize = true;
            this.lblRectanglePerimiterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectanglePerimiterTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectanglePerimiterTitle.Location = new System.Drawing.Point(18, 68);
            this.lblRectanglePerimiterTitle.Name = "lblRectanglePerimiterTitle";
            this.lblRectanglePerimiterTitle.Size = new System.Drawing.Size(75, 20);
            this.lblRectanglePerimiterTitle.TabIndex = 22;
            this.lblRectanglePerimiterTitle.Text = "Perimiter:";
            // 
            // lblRectangleDimensions
            // 
            this.lblRectangleDimensions.AutoSize = true;
            this.lblRectangleDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleDimensions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectangleDimensions.Location = new System.Drawing.Point(18, 16);
            this.lblRectangleDimensions.Name = "lblRectangleDimensions";
            this.lblRectangleDimensions.Size = new System.Drawing.Size(173, 20);
            this.lblRectangleDimensions.TabIndex = 19;
            this.lblRectangleDimensions.Text = "Rectangle Dimensions:";
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
            this.txtRectangleDimensions.TabIndex = 20;
            // 
            // lblRectangleAreaTitle
            // 
            this.lblRectangleAreaTitle.AutoSize = true;
            this.lblRectangleAreaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleAreaTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectangleAreaTitle.Location = new System.Drawing.Point(18, 42);
            this.lblRectangleAreaTitle.Name = "lblRectangleAreaTitle";
            this.lblRectangleAreaTitle.Size = new System.Drawing.Size(47, 20);
            this.lblRectangleAreaTitle.TabIndex = 21;
            this.lblRectangleAreaTitle.Text = "Area:";
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
            this.btnRectangleCalculate.TabIndex = 25;
            this.btnRectangleCalculate.UseVisualStyleBackColor = false;
            // 
            // pnlRectangleContainer
            // 
            this.pnlRectangleContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRectangleContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlRectangleContainer.Controls.Add(this.lblRectangleError);
            this.pnlRectangleContainer.Controls.Add(this.pnlRectangle);
            this.pnlRectangleContainer.Location = new System.Drawing.Point(278, 258);
            this.pnlRectangleContainer.Name = "pnlRectangleContainer";
            this.pnlRectangleContainer.Size = new System.Drawing.Size(426, 136);
            this.pnlRectangleContainer.TabIndex = 26;
            // 
            // pnlRectangle
            // 
            this.pnlRectangle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRectangle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlRectangle.Location = new System.Drawing.Point(163, 18);
            this.pnlRectangle.MaximumSize = new System.Drawing.Size(100, 100);
            this.pnlRectangle.Name = "pnlRectangle";
            this.pnlRectangle.Size = new System.Drawing.Size(100, 100);
            this.pnlRectangle.TabIndex = 27;
            this.pnlRectangle.Tag = "Black";
            // 
            // lblRectangleError
            // 
            this.lblRectangleError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRectangleError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRectangleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleError.Location = new System.Drawing.Point(52, 44);
            this.lblRectangleError.Margin = new System.Windows.Forms.Padding(0);
            this.lblRectangleError.Name = "lblRectangleError";
            this.lblRectangleError.Size = new System.Drawing.Size(322, 51);
            this.lblRectangleError.TabIndex = 16;
            this.lblRectangleError.Text = "Invalid Dimensions";
            this.lblRectangleError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMySchool
            // 
            this.tabMySchool.Controls.Add(this.pnlMySchool);
            this.tabMySchool.Controls.Add(this.lblMySchoolTitle);
            this.tabMySchool.Location = new System.Drawing.Point(4, 22);
            this.tabMySchool.Name = "tabMySchool";
            this.tabMySchool.Padding = new System.Windows.Forms.Padding(3);
            this.tabMySchool.Size = new System.Drawing.Size(982, 448);
            this.tabMySchool.TabIndex = 1;
            this.tabMySchool.Text = "My School";
            this.tabMySchool.UseVisualStyleBackColor = true;
            // 
            // lblMySchoolTitle
            // 
            this.lblMySchoolTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMySchoolTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySchoolTitle.Location = new System.Drawing.Point(243, 68);
            this.lblMySchoolTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblMySchoolTitle.Name = "lblMySchoolTitle";
            this.lblMySchoolTitle.Size = new System.Drawing.Size(496, 50);
            this.lblMySchoolTitle.TabIndex = 8;
            this.lblMySchoolTitle.Text = "Red River High School";
            this.lblMySchoolTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMySchool
            // 
            this.pnlMySchool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMySchool.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMySchool.Controls.Add(this.lblMySchoolMascot);
            this.pnlMySchool.Controls.Add(this.picMySchoolMascot);
            this.pnlMySchool.Controls.Add(this.btnMySchoolToggleMascot);
            this.pnlMySchool.Location = new System.Drawing.Point(278, 137);
            this.pnlMySchool.Name = "pnlMySchool";
            this.pnlMySchool.Size = new System.Drawing.Size(426, 104);
            this.pnlMySchool.TabIndex = 10;
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
            // tabHelloWorld
            // 
            this.tabHelloWorld.BackColor = System.Drawing.Color.White;
            this.tabHelloWorld.Controls.Add(this.lblHelloWorldTitle);
            this.tabHelloWorld.Controls.Add(this.pnlHelloWorld);
            this.tabHelloWorld.Location = new System.Drawing.Point(4, 22);
            this.tabHelloWorld.Margin = new System.Windows.Forms.Padding(0);
            this.tabHelloWorld.Name = "tabHelloWorld";
            this.tabHelloWorld.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelloWorld.Size = new System.Drawing.Size(982, 448);
            this.tabHelloWorld.TabIndex = 0;
            this.tabHelloWorld.Text = "Hello World";
            // 
            // pnlHelloWorld
            // 
            this.pnlHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHelloWorld.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHelloWorld.Controls.Add(this.picHelloWorldGerman);
            this.pnlHelloWorld.Controls.Add(this.btnHelloWorldFrench);
            this.pnlHelloWorld.Controls.Add(this.btnHelloWorldEnglish);
            this.pnlHelloWorld.Controls.Add(this.picHelloWorldEnglish);
            this.pnlHelloWorld.Controls.Add(this.btnHelloWorldGerman);
            this.pnlHelloWorld.Controls.Add(this.picHelloWorldFrench);
            this.pnlHelloWorld.Controls.Add(this.btnHelloWorldReset);
            this.pnlHelloWorld.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlHelloWorld.Location = new System.Drawing.Point(278, 137);
            this.pnlHelloWorld.Name = "pnlHelloWorld";
            this.pnlHelloWorld.Size = new System.Drawing.Size(426, 105);
            this.pnlHelloWorld.TabIndex = 28;
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
            // lblHelloWorldTitle
            // 
            this.lblHelloWorldTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelloWorldTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorldTitle.Location = new System.Drawing.Point(278, 68);
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
            this.tabMathre.Controls.Add(this.tabChange);
            this.tabMathre.Controls.Add(this.tabPizza);
            this.tabMathre.Controls.Add(this.tabUnknown);
            this.tabMathre.Controls.Add(this.tabSecret);
            this.tabMathre.Location = new System.Drawing.Point(0, 29);
            this.tabMathre.Margin = new System.Windows.Forms.Padding(0);
            this.tabMathre.Name = "tabMathre";
            this.tabMathre.Padding = new System.Drawing.Point(0, 0);
            this.tabMathre.SelectedIndex = 0;
            this.tabMathre.Size = new System.Drawing.Size(990, 474);
            this.tabMathre.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMathre.TabIndex = 4;
            this.tabMathre.Tag = "";
            // 
            // FrmMathre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(985, 498);
            this.Controls.Add(this.mnuBaseLayer);
            this.Controls.Add(this.tabMathre);
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
            this.pnlSecret.ResumeLayout(false);
            this.pnlSecret.PerformLayout();
            this.tabPizza.ResumeLayout(false);
            this.pnlPizza.ResumeLayout(false);
            this.pnlPizza.PerformLayout();
            this.pnlTip.ResumeLayout(false);
            this.pnlTip.PerformLayout();
            this.pnlDiningType.ResumeLayout(false);
            this.pnlDiningType.PerformLayout();
            this.pnlPizzaCost.ResumeLayout(false);
            this.pnlPizzaCost.PerformLayout();
            this.tabChange.ResumeLayout(false);
            this.pnlChangeMaker.ResumeLayout(false);
            this.pnlChangeMaker.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabDigits.ResumeLayout(false);
            this.pnlDigits.ResumeLayout(false);
            this.pnlDigits.PerformLayout();
            this.pnlDigitsResults.ResumeLayout(false);
            this.pnlDigitsResultsDisplay.ResumeLayout(false);
            this.pnlDigitsResultsDisplay.PerformLayout();
            this.tabTemperature.ResumeLayout(false);
            this.pnlTemperature.ResumeLayout(false);
            this.pnlTemperature.PerformLayout();
            this.pnlTemperatureResults.ResumeLayout(false);
            this.pnlTemperatureResults.PerformLayout();
            this.tabMyFavorites.ResumeLayout(false);
            this.pnlFavoriteControls.ResumeLayout(false);
            this.pnlFavoriteControls.PerformLayout();
            this.pnlFavoriteDisplay.ResumeLayout(false);
            this.tabRectangle.ResumeLayout(false);
            this.pnlRectangleControls.ResumeLayout(false);
            this.pnlRectangleControls.PerformLayout();
            this.pnlRectangleContainer.ResumeLayout(false);
            this.tabMySchool.ResumeLayout(false);
            this.pnlMySchool.ResumeLayout(false);
            this.pnlMySchool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).EndInit();
            this.tabHelloWorld.ResumeLayout(false);
            this.pnlHelloWorld.ResumeLayout(false);
            this.pnlHelloWorld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldFrench)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldGerman)).EndInit();
            this.tabMathre.ResumeLayout(false);
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
		private ToolStripMenuItem mnuRectangle;
		private ToolStripMenuItem mnuRectangleCalculate;
		private ToolStripMenuItem mnuFavorites;
		private ToolStripMenuItem mnuFavoriteActor;
		private ToolStripMenuItem mnuFavoriteMovie;
		private ToolStripMenuItem mnuFavoriteFruit;
		private ToolStripMenuItem mnuFavoriteColor;
		private ToolStripMenuItem mnuFavoriteHobby;
		private ToolStripMenuItem mnuTemperature;
		private ToolStripMenuItem mnuTemperatureFahrenheit;
		private ToolStripMenuItem mnuTemperatureCelsius;
		private ToolStripMenuItem mnuDigits;
		private ToolStripMenuItem mnuDigitsCalculate;
		private ToolStripMenuItem mnuChange;
		private ToolStripMenuItem mnuChangeCalculate;
		private ToolStripMenuItem mnuPizza;
		private ToolStripMenuItem mnuPizzaTakeout;
		private ToolStripMenuItem mnuPizzaDelivery;
		private ToolStripMenuItem mnuPizzaDollars;
		private ToolStripMenuItem mnuPizzaPercent;
		internal TabPage tabSecret;
		private Panel pnlSecret;
		internal RadioButton btnSecretDisable;
		internal Label lblSecretPrompt;
		internal RadioButton btnSecretEnable;
		internal TextBox txtSecretPassword;
		internal Label lblSecretTitle;
		internal TabPage tabUnknown;
		private TabPage tabPizza;
		private Panel pnlPizzaCost;
		private Panel pnlPizzaViewer;
		private Label lblPizzaCostAmount;
		internal Label lblPizzaCost;
		private Panel pnlPizza;
		private Panel pnlDiningType;
		private RadioButton btnTakeout;
		private RadioButton btnDelivery;
		internal Label lblPizzaSize;
		internal TextBox txtPizzaTip;
		private Panel pnlTip;
		private RadioButton btnPercent;
		private RadioButton btnDollars;
		internal Label lblPizzaTip;
		internal TextBox txtPizzaSize;
		internal Label lblPizzaTitle;
		private TabPage tabChange;
		private Panel panel3;
		private Label lblOnesCount;
		internal Label lblHundreds;
		private Label lblQuartersCount;
		internal Label lblChange;
		private Label lblDimesCount;
		private Label lblHundredsCount;
		private Label lblNickelsCount;
		internal Label lblFifties;
		private Label lblPenniesCount;
		internal Label lblTwenties;
		private Label lblFivesCount;
		internal Label lblTens;
		private Label lblTensCount;
		internal Label lblFives;
		private Label lblTwentiesCount;
		internal Label lblOnes;
		private Label lblFiftiesCount;
		internal Label lblQuarters;
		internal Label lblPennies;
		internal Label lblDimes;
		internal Label lblNickels;
		private Panel pnlChangeMaker;
		internal TextBox txtPaidAmount;
		internal Label lblPaidAmount;
		internal Label lblChangeMakerTitle;
		private TabPage tabDigits;
		private Panel pnlDigitsResults;
		private Panel pnlDigitsResultsDisplay;
		private Label lblDigitsResultsLabel;
		private Label lblDigitsListOdds;
		private Label lblDigitsListEvens;
		private Panel pnlDigits;
		internal TextBox txtNumber;
		internal Label lblDigits;
		private Label lblDigitsCount;
		internal Label lblDigitsCountLabel;
		internal Label lblDigitsTitle;
		private TabPage tabTemperature;
		private Panel pnlTemperatureResults;
		private Label lblCelsiusDisplay;
		internal Label lblFahrenheitDisplayLabel;
		private Label lblFahrenheitDisplay;
		internal Label lblCelsiusDisplayLabel;
		private Panel pnlTemperature;
		private RadioButton btnCelsius;
		internal TextBox txtTemperature;
		private RadioButton btnFahrenheit;
		internal Label lblTemperature;
		internal Label lblTemperatureTitle;
		internal TabPage tabMyFavorites;
		private Panel pnlFavoriteDisplay;
		private Panel pnlFavoriteImage;
		internal Label lblFavoriteInfo;
		private Panel pnlFavoriteControls;
		private RadioButton btnFavoriteMovie;
		private RadioButton btnFavoriteHobby;
		private RadioButton btnFavoriteColor;
		private RadioButton btnFavoriteActor;
		private RadioButton btnFavoriteFruit;
		internal Label lblFavoriteTitle;
		internal TabPage tabRectangle;
		private Panel pnlRectangleContainer;
		internal Label lblRectangleError;
		private Panel pnlRectangle;
		private Panel pnlRectangleControls;
		private Button btnRectangleCalculate;
		internal Label lblRectangleAreaTitle;
		internal TextBox txtRectangleDimensions;
		internal Label lblRectangleDimensions;
		internal Label lblRectanglePerimiterTitle;
		private Label lblRectangleArea;
		private Label lblRectanglePerimeter;
		internal Label lblRectangleTitle;
		internal TabPage tabMySchool;
		private Panel pnlMySchool;
		private Label lblMySchoolMascot;
		internal PictureBox picMySchoolMascot;
		internal Button btnMySchoolToggleMascot;
		internal Label lblMySchoolTitle;
		internal TabPage tabHelloWorld;
		internal Label lblHelloWorldTitle;
		private Panel pnlHelloWorld;
		internal PictureBox picHelloWorldGerman;
		internal RadioButton btnHelloWorldFrench;
		internal RadioButton btnHelloWorldEnglish;
		internal PictureBox picHelloWorldEnglish;
		internal RadioButton btnHelloWorldGerman;
		internal PictureBox picHelloWorldFrench;
		internal Button btnHelloWorldReset;
		internal TabControl tabMathre;
	}
}
