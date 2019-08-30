Namespace WindowsApplication1
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.QuantityLessThan10 = New DevExpress.XtraReports.UI.CalculatedField()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel4, Me.xrLabel3})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuantityLessThan10]")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(508F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(125F, 25F)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(258F, 0F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(225F, 25F)
			Me.xrLabel4.Text = "xrLabel4"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(117F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(100F, 25F)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' PageHeader
			' 
			Me.PageHeader.HeightF = 30F
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.HeightF = 30F
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Sales Person", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.HeightF = 40F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(17F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(333F, 25F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "Sales Person: [Sales Person]"
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.HeightF = 0F
			Me.GroupFooter1.Name = "GroupFooter1"
			Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
			' 
			' QuantityLessThan10
			' 
			Me.QuantityLessThan10.DataMember = "SalesPerson"
			Me.QuantityLessThan10.Expression = "Iif([Quantity]<10,'Less than 10',[Quantity])"
			Me.QuantityLessThan10.Name = "QuantityLessThan10"
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.HeightF = 100F
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.HeightF = 100F
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "WindowsApplication1.Properties.Settings.nwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "OrderID"
			table1.Name = "SalesPerson"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "Country"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "FirstName"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "LastName"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "ProductName"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "CategoryName"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "OrderDate"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "UnitPrice"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "Quantity"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "Discount"
			columnExpression10.Table = table1
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "Extended Price"
			columnExpression11.Table = table1
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "Sales Person"
			columnExpression12.Table = table1
			column12.Expression = columnExpression12
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.Columns.Add(column12)
			selectQuery1.Name = "SalesPerson"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.QuantityLessThan10})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "SalesPerson"
			Me.DataSource = Me.sqlDataSource1
			Me.Version = "17.2"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private QuantityLessThan10 As DevExpress.XtraReports.UI.CalculatedField
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
	End Class
End Namespace
