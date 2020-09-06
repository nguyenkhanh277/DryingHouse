﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DryingHouse.Persistence;
using DryingHouse.Persistence.Repositories;
using DryingHouse.Core.Domain;
using DryingHouse.Core;
using DryingHouse.Core.Helper;

namespace DryingHouse.View.RegistBarcodes
{
    public partial class frmRegistBarcodeAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        RegistBarcodeRepository _registBarcodeRepository;
        ProductRepository _productRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.KeyCode == Keys.F1)
            {
                btnSave_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        string _id = "";
        public frmRegistBarcodeAddEdit()
        {
            InitializeComponent();
        }

        public frmRegistBarcodeAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmRegistBarcodeAddEdit_Load(object sender, EventArgs e)
        {
            _registBarcodeRepository = new RegistBarcodeRepository(_projectDataContext);
            _productRepository = new ProductRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            LoadProductData();
            if (String.IsNullOrEmpty(_id))
            {
                Clear();
            }
            else
            {
                Close();
            }
        }

        private void frmRegistBarcodeAddEdit_Shown(object sender, EventArgs e)
        {
            txtQuantitySticker.Focus();
        }
        
        private void Clear()
        {
            dtpRegistDate.Value = DateTime.Now;
            txtQuantitySticker.Value = 0;
            txtQuantity.Value = 0;
            txtQuantitySticker.Focus();
        }

        private void LoadProductData()
        {
            cbbProduct.DataSource = _productRepository.GetAll().OrderBy(_ => _.PartNumber).ToList();
            cbbProduct.SelectedIndex = 0;
        }

        private bool CheckData()
        {
            if (cbbProduct.SelectedValue == null || String.IsNullOrEmpty(cbbProduct.Text.Trim()))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa chọn dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbProduct.Focus();
                return false;
            }
            else if (txtQuantitySticker.Value == 0)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantitySticker.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table RegistBarcode
                RegistBarcode registBarcode = new RegistBarcode();
                int seq = int.Parse(_registBarcodeRepository.GetSEQ(dtpRegistDate.Value,cbbProduct.Text.Trim()));
                int lot = int.Parse(_registBarcodeRepository.GetLOT(dtpRegistDate.Value, cbbProduct.Text.Trim()));
                int countLot = _registBarcodeRepository.GetCountOfLOT(dtpRegistDate.Value, cbbProduct.Text.Trim(), lot);
                int numberOfLOT = _productRepository.Get(cbbProduct.SelectedValue.ToString()).NumberOfLOT;
                string barcode = "";
                DataTable listBarcode = new DataTable();
                listBarcode.Columns.Add("Barcode", typeof(string));
                listBarcode.Columns.Add("PartNumber", typeof(string));
                listBarcode.Columns.Add("Date", typeof(string));
                listBarcode.Columns.Add("LOT", typeof(string));
                listBarcode.Columns.Add("SEQ", typeof(string));
                listBarcode.Columns.Add("Quantity", typeof(string));
                for (int i = 0; i < txtQuantitySticker.Value; i++)
                {
                    //Generate barcode
                    seq++;
                    countLot++;
                    if (countLot > numberOfLOT)
                    {
                        lot++;
                        countLot = 1;
                    }
                    
                    barcode = String.Format("{0}{1}{2}{3}",
                        cbbProduct.Text.Trim(),
                        dtpRegistDate.Value.ToString("yyMMdd"),
                        lot.ToString("00"),
                        seq.ToString("0000"));
                    //Set list barcode
                    listBarcode.Rows.Add(new string[] {
                        barcode,
                        "P/N: " + cbbProduct.Text.Trim(),
                        "Date: " +dtpRegistDate.Value.ToString("yyMMdd"),
                        "LOT: " + lot.ToString("00"),
                        "SEQ: " + seq.ToString("0000"),
                        "Quantity: " + txtQuantity.Value.ToString()
                    });
                    //Insert data
                    registBarcode = new RegistBarcode();
                    registBarcode.Id = _id;
                    registBarcode.PartNumber = cbbProduct.Text.Trim();
                    registBarcode.RegistDate = dtpRegistDate.Value.Date;
                    registBarcode.SEQ = seq.ToString("0000");
                    registBarcode.LOT = lot.ToString("00");
                    registBarcode.Quantity = (int)txtQuantity.Value;
                    registBarcode.Barcode = barcode;
                    _registBarcodeRepository.Save(registBarcode);
                }
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        _registBarcodeRepository.PrintListBarcode(listBarcode);
                        Clear();
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Products.frmProductAddEdit frm = new Products.frmProductAddEdit(true);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK && frm.Tag != null)
            {
                LoadProductData();
                cbbProduct.SelectedValue = (string)frm.Tag;
            }
        }
    }
}