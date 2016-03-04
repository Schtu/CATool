
// This file has been generated by the GUI designer. Do not modify.
namespace catoolgui
{
	public partial class createCert
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Entry certCaPass;
		
		private global::Gtk.ComboBox certTypeBox;
		
		private global::Gtk.HButtonBox hbuttonbox2;
		
		private global::Gtk.Button addSubjAlt;
		
		private global::Gtk.Button subAltremove;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.ComboBox subjAltBox;
		
		private global::Gtk.Entry subjAltEntry;
		
		private global::Gtk.ComboBox subjAltReason;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.HButtonBox hbuttonbox3;
		
		private global::Gtk.Button okCertButton;
		
		private global::Gtk.Button cancelCertButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget catoolgui.createCert
			this.Name = "catoolgui.createCert";
			this.Title = global::Mono.Unix.Catalog.GetString ("Certificate Creation - Step 2: Extensions");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Container child catoolgui.createCert.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Certificate Extensions</b>");
			this.label1.UseMarkup = true;
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(5)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.certCaPass = new global::Gtk.Entry ();
			this.certCaPass.CanFocus = true;
			this.certCaPass.Name = "certCaPass";
			this.certCaPass.IsEditable = true;
			this.certCaPass.Visibility = false;
			this.certCaPass.InvisibleChar = '•';
			this.table1.Add (this.certCaPass);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.certCaPass]));
			w2.TopAttach = ((uint)(4));
			w2.BottomAttach = ((uint)(5));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XPadding = ((uint)(10));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.certTypeBox = global::Gtk.ComboBox.NewText ();
			this.certTypeBox.AppendText (global::Mono.Unix.Catalog.GetString ("Clientcertificate"));
			this.certTypeBox.AppendText (global::Mono.Unix.Catalog.GetString ("Servercertificate"));
			this.certTypeBox.Name = "certTypeBox";
			this.certTypeBox.Active = 0;
			this.table1.Add (this.certTypeBox);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.certTypeBox]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XPadding = ((uint)(10));
			w3.YPadding = ((uint)(5));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.addSubjAlt = new global::Gtk.Button ();
			this.addSubjAlt.CanFocus = true;
			this.addSubjAlt.Name = "addSubjAlt";
			this.addSubjAlt.UseUnderline = true;
			this.addSubjAlt.Label = global::Mono.Unix.Catalog.GetString ("Add Entry");
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			this.addSubjAlt.Image = w4;
			this.hbuttonbox2.Add (this.addSubjAlt);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.addSubjAlt]));
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.subAltremove = new global::Gtk.Button ();
			this.subAltremove.CanFocus = true;
			this.subAltremove.Name = "subAltremove";
			this.subAltremove.UseUnderline = true;
			this.subAltremove.Label = global::Mono.Unix.Catalog.GetString ("Remove Entry");
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Menu);
			this.subAltremove.Image = w6;
			this.hbuttonbox2.Add (this.subAltremove);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.subAltremove]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.table1.Add (this.hbuttonbox2);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbuttonbox2]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Certificate - Type</b>");
			this.label2.UseMarkup = true;
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w9.XPadding = ((uint)(10));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Subject Alternative Names</b>");
			this.label4.UseMarkup = true;
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.XPadding = ((uint)(10));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>CA Password:</b>");
			this.label5.UseMarkup = true;
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w11.TopAttach = ((uint)(4));
			w11.BottomAttach = ((uint)(5));
			w11.XPadding = ((uint)(10));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.subjAltBox = global::Gtk.ComboBox.NewText ();
			this.subjAltBox.Name = "subjAltBox";
			this.table1.Add (this.subjAltBox);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.subjAltBox]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XPadding = ((uint)(10));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.subjAltEntry = new global::Gtk.Entry ();
			this.subjAltEntry.CanFocus = true;
			this.subjAltEntry.Name = "subjAltEntry";
			this.subjAltEntry.IsEditable = true;
			this.subjAltEntry.InvisibleChar = '•';
			this.table1.Add (this.subjAltEntry);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.subjAltEntry]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XPadding = ((uint)(10));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.subjAltReason = global::Gtk.ComboBox.NewText ();
			this.subjAltReason.AppendText (global::Mono.Unix.Catalog.GetString ("eMail"));
			this.subjAltReason.AppendText (global::Mono.Unix.Catalog.GetString ("IP"));
			this.subjAltReason.AppendText (global::Mono.Unix.Catalog.GetString ("URI"));
			this.subjAltReason.AppendText (global::Mono.Unix.Catalog.GetString ("DNS"));
			this.subjAltReason.Name = "subjAltReason";
			this.subjAltReason.Active = 2;
			this.table1.Add (this.subjAltReason);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.subjAltReason]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.XPadding = ((uint)(10));
			w14.XOptions = ((global::Gtk.AttachOptions)(1));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.table1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table1]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.hbuttonbox3 = new global::Gtk.HButtonBox ();
			this.hbuttonbox3.Name = "hbuttonbox3";
			this.hbuttonbox3.Spacing = -6;
			this.hbuttonbox3.BorderWidth = ((uint)(4));
			this.hbuttonbox3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
			this.okCertButton = new global::Gtk.Button ();
			this.okCertButton.CanFocus = true;
			this.okCertButton.Name = "okCertButton";
			this.okCertButton.UseStock = true;
			this.okCertButton.UseUnderline = true;
			this.okCertButton.Label = "gtk-ok";
			this.hbuttonbox3.Add (this.okCertButton);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox3 [this.okCertButton]));
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
			this.cancelCertButton = new global::Gtk.Button ();
			this.cancelCertButton.CanFocus = true;
			this.cancelCertButton.Name = "cancelCertButton";
			this.cancelCertButton.UseStock = true;
			this.cancelCertButton.UseUnderline = true;
			this.cancelCertButton.Label = "gtk-cancel";
			this.hbuttonbox3.Add (this.cancelCertButton);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox3 [this.cancelCertButton]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox3.Add (this.hbuttonbox3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.hbuttonbox3]));
			w18.Position = 0;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 451;
			this.DefaultHeight = 242;
			this.Show ();
			this.addSubjAlt.Clicked += new global::System.EventHandler (this.OnaddSubjAltClicked);
			this.subAltremove.Clicked += new global::System.EventHandler (this.OnSubAltremoveClicked);
			this.okCertButton.Clicked += new global::System.EventHandler (this.OnOkCertButtonClicked);
			this.cancelCertButton.Clicked += new global::System.EventHandler (this.OnCancelCertButtonClicked);
		}
	}
}
