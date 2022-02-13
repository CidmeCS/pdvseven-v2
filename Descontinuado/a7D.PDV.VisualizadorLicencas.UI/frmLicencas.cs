﻿using a7D.PDV.BLL;
using a7D.PDV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a7D.PDV.VisualizadorLicencas.UI
{
    public partial class frmLicencas : Form
    {
        private List<PDVInformation> pdvs;
        private frmLicencas()
        {
            InitializeComponent();
        }

        public frmLicencas(List<PDVInformation> lista) : this()
        {
            lista.All(p => p.CarregarDados());
            this.pdvs = lista;
        }

        private void frmLicencas_Load(object sender, EventArgs e)
        {
            gdvLicencas.DataSource = pdvs.Select(p => new { p.IDPDV, p.Nome, p.ChaveHardware, Tipo = p.TipoPDV.IDTipoPDV.Value, p.UltimaAlteracao, p.UltimoAcesso, p.Versao, p.Ativo }).OrderBy(p => p.Tipo).ThenBy(p => p.IDPDV).ToList();
        }
    }
}
