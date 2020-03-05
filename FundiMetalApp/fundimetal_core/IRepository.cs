using fundimetal_core;
using fundimetal_core.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace fundimetal.Core

{ 
    public interface IRepository
    {
        DataTable GetAllDataBurns(List<String> errors , string rutaArchivoXmlFuente);
        DataTable getInfoClientes(XmlDocument xdoc);
        DataTable getEspecificacionClientes(XmlDocument xdoc);

        List<ListItemCombo> GetInfoClientesComboBox();
        List<ListItemCombo> GetInformacionClientesComboBox();

        List<ListItemCombo> GetInfoProductosComboBox();
        List<ListItemCombo> GetInfoPresentacionComboBox();

        DataTable GetInfoClientesById( string  idCliente);
        //bool SaveNewCliente(ClienteModel clienteModel);

        bool SaveOrEditCliente(ClienteModel clienteModel);
        ClienteModel GetClienteById( string Id);
        ClienteModel GetInfoClienteById(string Id);
        bool SaveOrEditInfoCliente(ClienteModel clienteModel);
        DataTable getTipoProducto(XmlDocument xDocTipoProduct);
        DataTable getTipoLingote(XmlDocument xdocLingote);
        bool SaveOrEditParameter(DataTable dataSource1, DataTable dataSource2);
        bool SaveOrEditTipoProduct(DataTable dataSource, XmlDocument xDocTipoProduct);
        void SaveEditLingote(DataTable dataSource, XmlDocument xdocLingote);
        void deleteByIdEspecificacionCliente(string id);
    }
}