
// This file has been generated by the GUI designer. Do not modify.
namespace catoolgui
{
	public partial class createNewCA
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.ComboBox cipherAlgoBox;
		
		private global::Gtk.Entry commonNameCA;
		
		private global::Gtk.Entry CountryCA;
		
		private global::Gtk.ComboBox DigestCA;
		
		private global::Gtk.Entry eMailCA;
		
		private global::Gtk.Button extButton;
		
		private global::Gtk.HButtonBox hbuttonbox4;
		
		private global::Gtk.Button OKButtonCA;
		
		private global::Gtk.Button button9;
		
		private global::Gtk.ComboBox KeySizeBoxCA;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.Label label12;
		
		private global::Gtk.Label label13;
		
		private global::Gtk.Label label14;
		
		private global::Gtk.Label label15;
		
		private global::Gtk.Label label16;
		
		private global::Gtk.Label label17;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.Entry LocalityCA;
		
		private global::Gtk.Entry NameCA;
		
		private global::Gtk.Entry OrganizationCA;
		
		private global::Gtk.Entry OrganizationUnitCA;
		
		private global::Gtk.Entry PasswordCA;
		
		private global::Gtk.Entry PasswordCAConfirmation;
		
		private global::Gtk.Entry StateProvinceCA;
		
		private global::Gtk.Entry ValidCA;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget catoolgui.createNewCA
			this.CanDefault = true;
			this.CanFocus = true;
			this.Name = "catoolgui.createNewCA";
			this.Title = global::Mono.Unix.Catalog.GetString ("CreateNewCA");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Modal = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			// Container child catoolgui.createNewCA.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(18)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.cipherAlgoBox = global::Gtk.ComboBox.NewText ();
			this.cipherAlgoBox.AppendText (global::Mono.Unix.Catalog.GetString ("aes192"));
			this.cipherAlgoBox.AppendText (global::Mono.Unix.Catalog.GetString ("aes256"));
			this.cipherAlgoBox.Name = "cipherAlgoBox";
			this.cipherAlgoBox.Active = 0;
			this.table1.Add (this.cipherAlgoBox);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.cipherAlgoBox]));
			w1.TopAttach = ((uint)(14));
			w1.BottomAttach = ((uint)(15));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XPadding = ((uint)(10));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.commonNameCA = new global::Gtk.Entry ();
			this.commonNameCA.CanFocus = true;
			this.commonNameCA.Name = "commonNameCA";
			this.commonNameCA.IsEditable = true;
			this.commonNameCA.InvisibleChar = '•';
			this.table1.Add (this.commonNameCA);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.commonNameCA]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XPadding = ((uint)(10));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.CountryCA = new global::Gtk.Entry ();
			this.CountryCA.CanFocus = true;
			this.CountryCA.Name = "CountryCA";
			this.CountryCA.IsEditable = true;
			this.CountryCA.MaxLength = 2;
			this.CountryCA.InvisibleChar = '•';
			this.table1.Add (this.CountryCA);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.CountryCA]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XPadding = ((uint)(10));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.DigestCA = global::Gtk.ComboBox.NewText ();
			this.DigestCA.AppendText (global::Mono.Unix.Catalog.GetString ("sha256"));
			this.DigestCA.AppendText (global::Mono.Unix.Catalog.GetString ("sha384"));
			this.DigestCA.AppendText (global::Mono.Unix.Catalog.GetString ("sha512"));
			this.DigestCA.Name = "DigestCA";
			this.DigestCA.Active = 0;
			this.DigestCA.HasFrame = false;
			this.table1.Add (this.DigestCA);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.DigestCA]));
			w4.TopAttach = ((uint)(15));
			w4.BottomAttach = ((uint)(16));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XPadding = ((uint)(10));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.eMailCA = new global::Gtk.Entry ();
			this.eMailCA.CanFocus = true;
			this.eMailCA.Name = "eMailCA";
			this.eMailCA.IsEditable = true;
			this.eMailCA.InvisibleChar = '•';
			this.table1.Add (this.eMailCA);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.eMailCA]));
			w5.TopAttach = ((uint)(8));
			w5.BottomAttach = ((uint)(9));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XPadding = ((uint)(10));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.extButton = new global::Gtk.Button ();
			this.extButton.CanFocus = true;
			this.extButton.Name = "extButton";
			this.extButton.UseUnderline = true;
			this.extButton.Label = global::Mono.Unix.Catalog.GetString ("Set CRL-Path");
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.extButton.Image = w6;
			this.table1.Add (this.extButton);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.extButton]));
			w7.TopAttach = ((uint)(16));
			w7.BottomAttach = ((uint)(17));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(0));
			w7.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table1.Gtk.Table+TableChild
			this.hbuttonbox4 = new global::Gtk.HButtonBox ();
			this.hbuttonbox4.Name = "hbuttonbox4";
			this.hbuttonbox4.Spacing = 83;
			this.hbuttonbox4.BorderWidth = ((uint)(3));
			// Container child hbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
			this.OKButtonCA = new global::Gtk.Button ();
			this.OKButtonCA.CanFocus = true;
			this.OKButtonCA.Name = "OKButtonCA";
			this.OKButtonCA.UseStock = true;
			this.OKButtonCA.UseUnderline = true;
			this.OKButtonCA.Label = "gtk-ok";
			this.hbuttonbox4.Add (this.OKButtonCA);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox4 [this.OKButtonCA]));
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
			this.button9 = new global::Gtk.Button ();
			this.button9.CanFocus = true;
			this.button9.Name = "button9";
			this.button9.UseStock = true;
			this.button9.UseUnderline = true;
			this.button9.Label = "gtk-cancel";
			this.hbuttonbox4.Add (this.button9);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox4 [this.button9]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.table1.Add (this.hbuttonbox4);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbuttonbox4]));
			w10.TopAttach = ((uint)(17));
			w10.BottomAttach = ((uint)(18));
			w10.XOptions = ((global::Gtk.AttachOptions)(0));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.KeySizeBoxCA = global::Gtk.ComboBox.NewText ();
			this.KeySizeBoxCA.AppendText (global::Mono.Unix.Catalog.GetString ("2048"));
			this.KeySizeBoxCA.AppendText (global::Mono.Unix.Catalog.GetString ("4096"));
			this.KeySizeBoxCA.Name = "KeySizeBoxCA";
			this.KeySizeBoxCA.Active = 1;
			this.table1.Add (this.KeySizeBoxCA);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.KeySizeBoxCA]));
			w11.TopAttach = ((uint)(13));
			w11.BottomAttach = ((uint)(14));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XPadding = ((uint)(10));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Recommended Settings</b>");
			this.label1.UseMarkup = true;
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w12.TopAttach = ((uint)(11));
			w12.BottomAttach = ((uint)(12));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XPadding = ((uint)(10));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 0F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Organization Unit Name (optional)");
			this.table1.Add (this.label10);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.label10]));
			w13.TopAttach = ((uint)(7));
			w13.BottomAttach = ((uint)(8));
			w13.XPadding = ((uint)(10));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 0F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("eMail-Adress (optional)");
			this.table1.Add (this.label11);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.label11]));
			w14.TopAttach = ((uint)(8));
			w14.BottomAttach = ((uint)(9));
			w14.XPadding = ((uint)(10));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.Xalign = 0F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Valid (Days)");
			this.table1.Add (this.label12);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.label12]));
			w15.TopAttach = ((uint)(12));
			w15.BottomAttach = ((uint)(13));
			w15.XPadding = ((uint)(10));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Keylength");
			this.table1.Add (this.label13);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.label13]));
			w16.TopAttach = ((uint)(13));
			w16.BottomAttach = ((uint)(14));
			w16.XPadding = ((uint)(10));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.Xalign = 0F;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Message Digest");
			this.table1.Add (this.label14);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.label14]));
			w17.TopAttach = ((uint)(15));
			w17.BottomAttach = ((uint)(16));
			w17.XPadding = ((uint)(10));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.Xalign = 0F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Cipher Algorithm");
			this.table1.Add (this.label15);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.label15]));
			w18.TopAttach = ((uint)(14));
			w18.BottomAttach = ((uint)(15));
			w18.XPadding = ((uint)(10));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.Xalign = 0F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("CRL");
			this.table1.Add (this.label16);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.label16]));
			w19.TopAttach = ((uint)(16));
			w19.BottomAttach = ((uint)(17));
			w19.XPadding = ((uint)(10));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label ();
			this.label17.Name = "label17";
			this.label17.Xpad = 10;
			this.label17.Xalign = 0F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("Common Name");
			this.table1.Add (this.label17);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.label17]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xpad = 10;
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Name (for storage)");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Country Name ( Must be a 2 letter code)");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w22.TopAttach = ((uint)(3));
			w22.BottomAttach = ((uint)(4));
			w22.XPadding = ((uint)(10));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Password (Used for signing)");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w23.TopAttach = ((uint)(9));
			w23.BottomAttach = ((uint)(10));
			w23.XPadding = ((uint)(10));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Password (Confirmation)");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w24.TopAttach = ((uint)(10));
			w24.BottomAttach = ((uint)(11));
			w24.XPadding = ((uint)(10));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>CREATE NEW CA</b>");
			this.label6.UseMarkup = true;
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("State / Province Name");
			this.table1.Add (this.label7);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1 [this.label7]));
			w26.TopAttach = ((uint)(4));
			w26.BottomAttach = ((uint)(5));
			w26.XPadding = ((uint)(10));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Locality Name (optional)");
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1 [this.label8]));
			w27.TopAttach = ((uint)(5));
			w27.BottomAttach = ((uint)(6));
			w27.XPadding = ((uint)(10));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Organization Name");
			this.table1.Add (this.label9);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1 [this.label9]));
			w28.TopAttach = ((uint)(6));
			w28.BottomAttach = ((uint)(7));
			w28.XPadding = ((uint)(10));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.LocalityCA = new global::Gtk.Entry ();
			this.LocalityCA.CanFocus = true;
			this.LocalityCA.Name = "LocalityCA";
			this.LocalityCA.IsEditable = true;
			this.LocalityCA.InvisibleChar = '•';
			this.table1.Add (this.LocalityCA);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.LocalityCA]));
			w29.TopAttach = ((uint)(5));
			w29.BottomAttach = ((uint)(6));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XPadding = ((uint)(10));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.NameCA = new global::Gtk.Entry ();
			this.NameCA.CanFocus = true;
			this.NameCA.Name = "NameCA";
			this.NameCA.IsEditable = true;
			this.NameCA.InvisibleChar = '•';
			this.table1.Add (this.NameCA);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1 [this.NameCA]));
			w30.TopAttach = ((uint)(1));
			w30.BottomAttach = ((uint)(2));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XPadding = ((uint)(10));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.OrganizationCA = new global::Gtk.Entry ();
			this.OrganizationCA.CanFocus = true;
			this.OrganizationCA.Name = "OrganizationCA";
			this.OrganizationCA.IsEditable = true;
			this.OrganizationCA.InvisibleChar = '•';
			this.table1.Add (this.OrganizationCA);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1 [this.OrganizationCA]));
			w31.TopAttach = ((uint)(6));
			w31.BottomAttach = ((uint)(7));
			w31.LeftAttach = ((uint)(1));
			w31.RightAttach = ((uint)(2));
			w31.XPadding = ((uint)(10));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.OrganizationUnitCA = new global::Gtk.Entry ();
			this.OrganizationUnitCA.CanFocus = true;
			this.OrganizationUnitCA.Name = "OrganizationUnitCA";
			this.OrganizationUnitCA.IsEditable = true;
			this.OrganizationUnitCA.InvisibleChar = '•';
			this.table1.Add (this.OrganizationUnitCA);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1 [this.OrganizationUnitCA]));
			w32.TopAttach = ((uint)(7));
			w32.BottomAttach = ((uint)(8));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.XPadding = ((uint)(10));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.PasswordCA = new global::Gtk.Entry ();
			this.PasswordCA.CanFocus = true;
			this.PasswordCA.Name = "PasswordCA";
			this.PasswordCA.IsEditable = true;
			this.PasswordCA.Visibility = false;
			this.PasswordCA.InvisibleChar = '•';
			this.table1.Add (this.PasswordCA);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1 [this.PasswordCA]));
			w33.TopAttach = ((uint)(9));
			w33.BottomAttach = ((uint)(10));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(2));
			w33.XPadding = ((uint)(10));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.PasswordCAConfirmation = new global::Gtk.Entry ();
			this.PasswordCAConfirmation.CanFocus = true;
			this.PasswordCAConfirmation.Name = "PasswordCAConfirmation";
			this.PasswordCAConfirmation.IsEditable = true;
			this.PasswordCAConfirmation.Visibility = false;
			this.PasswordCAConfirmation.InvisibleChar = '•';
			this.table1.Add (this.PasswordCAConfirmation);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table1 [this.PasswordCAConfirmation]));
			w34.TopAttach = ((uint)(10));
			w34.BottomAttach = ((uint)(11));
			w34.LeftAttach = ((uint)(1));
			w34.RightAttach = ((uint)(2));
			w34.XPadding = ((uint)(10));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.StateProvinceCA = new global::Gtk.Entry ();
			this.StateProvinceCA.CanFocus = true;
			this.StateProvinceCA.Name = "StateProvinceCA";
			this.StateProvinceCA.IsEditable = true;
			this.StateProvinceCA.InvisibleChar = '•';
			this.table1.Add (this.StateProvinceCA);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table1 [this.StateProvinceCA]));
			w35.TopAttach = ((uint)(4));
			w35.BottomAttach = ((uint)(5));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(2));
			w35.XPadding = ((uint)(10));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ValidCA = new global::Gtk.Entry ();
			this.ValidCA.CanFocus = true;
			this.ValidCA.Name = "ValidCA";
			this.ValidCA.Text = global::Mono.Unix.Catalog.GetString ("365");
			this.ValidCA.IsEditable = true;
			this.ValidCA.InvisibleChar = '•';
			this.table1.Add (this.ValidCA);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table1 [this.ValidCA]));
			w36.TopAttach = ((uint)(12));
			w36.BottomAttach = ((uint)(13));
			w36.LeftAttach = ((uint)(1));
			w36.RightAttach = ((uint)(2));
			w36.XPadding = ((uint)(10));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 452;
			this.DefaultHeight = 616;
			this.HasDefault = true;
			this.Show ();
			this.OKButtonCA.Clicked += new global::System.EventHandler (this.okButtonclicked);
			this.button9.Clicked += new global::System.EventHandler (this.cancelClicked);
			this.extButton.Clicked += new global::System.EventHandler (this.OnExtButtonClicked);
		}
	}
}
