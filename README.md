# Laboratory Activity: Week 9–10

This laboratory activity focuses on developing two major components using VB.NET Windows Forms Application:

1. Crystal Reports Receipt System
2. Dashboard Home Form using MDI Parent Form

The activity demonstrates reporting, navigation systems, dashboard design, KPI cards, and user interface consistency.

---

# Project Title

Inventory Dashboard and Crystal Reports System using VB.NET

---

# Objectives

The objectives of this laboratory activity are:

1. To create Crystal Reports using VB.NET
2. To generate inventory receipts
3. To use datasets in reporting
4. To design an MDI Parent dashboard
5. To implement navigation systems
6. To create KPI statistic cards
7. To apply a consistent UI theme

---

# Technologies Used

- VB.NET
- Windows Forms
- Crystal Reports
- DataSet
- MDI Parent Form
- Visual Studio

---

# Project Structure

```plaintext
InventoryDashboardProject/
│
├── MainDashboard.vb
├── CrystalReport1.rpt
├── ReceiptViewerForm.vb
├── InventoryDataSet.xsd
├── ProductsForm.vb
├── ReportsForm.vb
├── README.md
└── Screenshots/
```

---

# PART A — Crystal Reports Receipt

---

# Step 1 — Create a New Crystal Report

## Procedure

1. Open Visual Studio
2. Right-click the project
3. Select:
   ```plaintext
   Add → New Item
   ```
4. Choose:
   ```plaintext
   Crystal Report
   ```
5. Name it:
   ```plaintext
   CrystalReport1.rpt
   ```

---

# Step 2 — Use Inventory DataSet

## Create Dataset

1. Right-click project
2. Select:
   ```plaintext
   Add → New Item → DataSet
   ```
3. Name it:
   ```plaintext
   InventoryDataSet.xsd
   ```

---

# Sample Table Structure

| Field Name | Data Type |
|---|---|
| ItemName | String |
| Quantity | Integer |
| Price | Decimal |
| Total | Decimal |

---

# Step 3 — Add Item, Qty, Price, and Total Fields

Inside Crystal Report:

- Drag the following fields into the Details Section:
  - ItemName
  - Quantity
  - Price
  - Total

---

# Formula for Total

```plaintext
Total = Quantity × Price
```

---

# Step 4 — Add Grand Total in Report Footer

## Procedure

1. Right-click the Total field
2. Select:
   ```plaintext
   Insert → Summary
   ```
3. Choose:
   ```plaintext
   Sum
   ```
4. Place it in:
   ```plaintext
   Report Footer
   ```

---

# Step 5 — Embed Crystal Report in Form

## Create New Form

```plaintext
ReceiptViewerForm.vb
```

---

# Add CrystalReportViewer

From Toolbox:

```plaintext
CrystalReportViewer
```

Set:

```plaintext
Dock = Fill
```

---

# ReceiptViewerForm.vb Code

```vb
Imports CrystalDecisions.CrystalReports.Engine

Public Class ReceiptViewerForm

    Private Sub ReceiptViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim report As New CrystalReport1()

        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()

    End Sub

End Class
```

---

# PART B — Dashboard Home Form

---

# Step 1 — Design MDI Parent Form

## Create Form

```plaintext
MainDashboard.vb
```

---

# Set Form Property

```plaintext
IsMdiContainer = True
```

---

# Sample Dashboard Layout

```plaintext
-----------------------------------------
| Navigation |                          |
| Panel      |       Main Area          |
|            |                          |
|            |                          |
-----------------------------------------
```

---

# Step 2 — Add Left Navigation Panel

## Add Panel

| Property | Value |
|---|---|
| Dock | Left |
| Width | 200 |

---

# Add Buttons

| Button Name | Text |
|---|---|
| btnHome | Home |
| btnProducts | Products |
| btnReports | Reports |
| btnLogout | Logout |

---

# Step 3 — Create KPI Statistic Cards

## KPI Cards

Create 3 Panels representing statistics.

| KPI Card | Example Value |
|---|---|
| Total Products | 150 |
| Total Sales | ₱25,000 |
| Total Orders | 320 |

---

# Suggested KPI Layout

```plaintext
-----------------------------------------
|  Products  |  Sales  |  Orders       |
|    150     | 25000   |   320         |
-----------------------------------------
```

---

# Step 4 — Wire Navigation Buttons

## Open Child Forms

### btnProducts_Click

```vb
Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click

    Dim frm As New ProductsForm()

    frm.MdiParent = Me
    frm.Show()

End Sub
```

---

### btnReports_Click

```vb
Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

    Dim frm As New ReceiptViewerForm()

    frm.MdiParent = Me
    frm.Show()

End Sub
```

---

# Step 5 — Apply Consistent Color Theme

## Suggested Colors

| Component | Color |
|---|---|
| Navigation Panel | Dark Blue |
| Buttons | Blue |
| Main Background | White |
| KPI Cards | Light Blue |

---

# Complete MainDashboard.vb Code

```vb
Public Class MainDashboard

    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click

        Dim frm As New ProductsForm()

        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        Dim frm As New ReceiptViewerForm()

        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Me.Close()

    End Sub

End Class
```

---

# Sample ProductsForm.vb

```vb
Public Class ProductsForm

    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
```

---

# Features of the System

| Feature | Description |
|---|---|
| Crystal Reports | Generates receipt reports |
| Report Viewer | Displays reports inside form |
| Inventory DataSet | Stores report data |
| MDI Parent Form | Multiple child forms |
| Navigation Panel | Dashboard navigation |
| KPI Cards | Displays statistics |
| Consistent Theme | Better UI design |

---

# Testing the System

## Test Case 1 — Open Report

| Action | Expected Result |
|---|---|
| Click Reports Button | Crystal Report opens |

---

## Test Case 2 — Open Products Form

| Action | Expected Result |
|---|---|
| Click Products Button | Products Form opens |

---

## Test Case 3 — Dashboard Navigation

| Action | Expected Result |
|---|---|
| Click Navigation Buttons | Forms switch properly |

---

# How to Run the Project

1. Open project in Visual Studio
2. Create the forms:
   - MainDashboard
   - ProductsForm
   - ReceiptViewerForm
3. Create CrystalReport1.rpt
4. Create InventoryDataSet.xsd
5. Add CrystalReportViewer
6. Add navigation buttons
7. Add KPI panels
8. Copy the provided VB.NET code
9. Run the application

---

# Learning Outcomes

This laboratory activity helped develop skills in:

- Crystal Reports
- Report generation
- Dashboard design
- MDI applications
- Navigation systems
- UI design consistency
- Dataset management
- VB.NET programming

---

# Conclusion

The laboratory activity successfully demonstrated the creation of a Crystal Reports receipt system and a dashboard home form using VB.NET. The project implemented report viewing, dataset usage, MDI parent-child forms, KPI statistic cards, and navigation systems. The activity also improved understanding of user interface consistency and application organization.

---

# Future Improvements

- Add database integration
- Add real-time dashboard updates
- Add login authentication
- Export reports to PDF
- Add charts and graphs
- Add inventory management features
- Add user activity logs

---

# Submitted By

| Information | Details |
|---|---|
| Name | Joezainne Melitante |
| Course & Section | 2.1 BSIT |
| Instructor | Mr. Edward James V. Grageda |
| Date Submitted | May 23, 2026 |

---
