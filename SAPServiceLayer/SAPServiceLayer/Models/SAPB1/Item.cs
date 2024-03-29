﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPServiceLayer.Models.SAPB1
{
    internal class Item
    {
        public Edm.String? ItemCode { get; set; }

        public Edm.String ItemName { get; set; }
        public Edm.String ForeignName { get; set; }
        public Edm.Int32 ItemsGroupCode { get; set; }
        public Edm.Int32 CustomsGroupCode { get; set; }
        public Edm.String SalesVATGroup { get; set; }
        public Edm.String BarCode { get; set; }
        public SAPB1.BoYesNoEnum VatLiable { get; set; }
        public SAPB1.BoYesNoEnum PurchaseItem { get; set; }
        public SAPB1.BoYesNoEnum SalesItem { get; set; }
        public SAPB1.BoYesNoEnum InventoryItem { get; set; }
        public Edm.String IncomeAccount { get; set; }
        public Edm.String ExemptIncomeAccount { get; set; }
        public Edm.String ExpanseAccount { get; set; }
        public Edm.String Mainsupplier { get; set; }
        public Edm.String SupplierCatalogNo { get; set; }
        public Edm.Double DesiredInventory { get; set; }
        public Edm.Double MinInventory { get; set; }
        public Edm.String Picture { get; set; }
        public Edm.String User_Text { get; set; }
        public Edm.String SerialNum { get; set; }
        public Edm.Double CommissionPercent { get; set; }
        public Edm.Double CommissionSum { get; set; }
        public Edm.Int32 CommissionGroup { get; set; }
        public SAPB1.BoItemTreeTypes TreeType { get; set; }
        public SAPB1.BoYesNoEnum AssetItem { get; set; }
        public Edm.String DataExportCode { get; set; }
        public Edm.Int32 Manufacturer { get; set; }
        public Edm.Double QuantityOnStock { get; set; }
        public Edm.Double QuantityOrderedFromVendors { get; set; }
        public Edm.Double QuantityOrderedByCustomers { get; set; }
        public SAPB1.BoYesNoEnum ManageSerialNumbers { get; set; }
        public SAPB1.BoYesNoEnum ManageBatchNumbers { get; set; }
        public SAPB1.BoYesNoEnum Valid { get; set; }
        public Edm.DateTime ValidFrom { get; set; }
        public Edm.DateTime ValidTo { get; set; }
        public Edm.String ValidRemarks { get; set; }
        public SAPB1.BoYesNoEnum Frozen { get; set; }
        public Edm.DateTime FrozenFrom { get; set; }
        public Edm.DateTime FrozenTo { get; set; }
        public Edm.String FrozenRemarks { get; set; }
        public Edm.String SalesUnit { get; set; }
        public Edm.Double SalesItemsPerUnit { get; set; }
        public Edm.String SalesPackagingUnit { get; set; }
        public Edm.Double SalesQtyPerPackUnit { get; set; }
        public Edm.Double SalesUnitLength { get; set; }
        public Edm.Int32 SalesLengthUnit { get; set; }
        public Edm.Double SalesUnitWidth { get; set; }
        public Edm.Int32 SalesWidthUnit { get; set; }
        public Edm.Double SalesUnitHeight { get; set; }
        public Edm.Int32 SalesHeightUnit { get; set; }
        public Edm.Double SalesUnitVolume { get; set; }
        public Edm.Int32 SalesVolumeUnit { get; set; }
        public Edm.Double SalesUnitWeight { get; set; }
        public Edm.Int32 SalesWeightUnit { get; set; }
        public Edm.String PurchaseUnit { get; set; }
        public Edm.Double PurchaseItemsPerUnit { get; set; }
        public Edm.String PurchasePackagingUnit { get; set; }
        public Edm.Double PurchaseQtyPerPackUnit { get; set; }
        public Edm.Double PurchaseUnitLength { get; set; }
        public Edm.Int32 PurchaseLengthUnit { get; set; }
        public Edm.Double PurchaseUnitWidth { get; set; }
        public Edm.Int32 PurchaseWidthUnit { get; set; }
        public Edm.Double PurchaseUnitHeight { get; set; }
        public Edm.Int32 PurchaseHeightUnit { get; set; }
        public Edm.Double PurchaseUnitVolume { get; set; }
        public Edm.Int32 PurchaseVolumeUnit { get; set; }
        public Edm.Double PurchaseUnitWeight { get; set; }
        public Edm.Int32 PurchaseWeightUnit { get; set; }
        public Edm.String PurchaseVATGroup { get; set; }
        public Edm.Double SalesFactor1 { get; set; }
        public Edm.Double SalesFactor2 { get; set; }
        public Edm.Double SalesFactor3 { get; set; }
        public Edm.Double SalesFactor4 { get; set; }
        public Edm.Double PurchaseFactor1 { get; set; }
        public Edm.Double PurchaseFactor2 { get; set; }
        public Edm.Double PurchaseFactor3 { get; set; }
        public Edm.Double PurchaseFactor4 { get; set; }
        public Edm.Double MovingAveragePrice { get; set; }
        public Edm.String ForeignRevenuesAccount { get; set; }
        public Edm.String ECRevenuesAccount { get; set; }
        public Edm.String ForeignExpensesAccount { get; set; }
        public Edm.String ECExpensesAccount { get; set; }
        public Edm.Double AvgStdPrice { get; set; }
        public Edm.String DefaultWarehouse { get; set; }
        public Edm.Int32 ShipType { get; set; }
        public SAPB1.BoGLMethods GLMethod { get; set; }
        public SAPB1.BoTaxTypes TaxType { get; set; }
        public Edm.Double MaxInventory { get; set; }
        public SAPB1.BoYesNoEnum ManageStockByWarehouse { get; set; }
        public Edm.Int32 PurchaseHeightUnit1 { get; set; }
        public Edm.Double PurchaseUnitHeight1 { get; set; }
        public Edm.Int32 PurchaseLengthUnit1 { get; set; }
        public Edm.Double PurchaseUnitLength1 { get; set; }
        public Edm.Int32 PurchaseWeightUnit1 { get; set; }
        public Edm.Double PurchaseUnitWeight1 { get; set; }
        public Edm.Int32 PurchaseWidthUnit1 { get; set; }
        public Edm.Double PurchaseUnitWidth1 { get; set; }
        public Edm.Int32 SalesHeightUnit1 { get; set; }
        public Edm.Double SalesUnitHeight1 { get; set; }
        public Edm.Int32 SalesLengthUnit1 { get; set; }
        public Edm.Double SalesUnitLength1 { get; set; }
        public Edm.Int32 SalesWeightUnit1 { get; set; }
        public Edm.Double SalesUnitWeight1 { get; set; }
        public Edm.Int32 SalesWidthUnit1 { get; set; }
        public Edm.Double SalesUnitWidth1 { get; set; }
        public SAPB1.BoYesNoEnum ForceSelectionOfSerialNumber { get; set; }
        public SAPB1.BoYesNoEnum ManageSerialNumbersOnReleaseOnly { get; set; }
        public SAPB1.BoYesNoEnum WTLiable { get; set; }
        public SAPB1.BoInventorySystem CostAccountingMethod { get; set; }
        public Edm.String SWW { get; set; }
        public Edm.String WarrantyTemplate { get; set; }
        public SAPB1.BoYesNoEnum IndirectTax { get; set; }
        public Edm.String ArTaxCode { get; set; }
        public Edm.String ApTaxCode { get; set; }
        public Edm.String BaseUnitName { get; set; }
        public Edm.String ItemCountryOrg { get; set; }
        public SAPB1.BoIssueMethod IssueMethod { get; set; }
        public SAPB1.BoManageMethod SRIAndBatchManageMethod { get; set; }
        public SAPB1.BoYesNoEnum IsPhantom { get; set; }
        public Edm.String InventoryUOM { get; set; }
        public SAPB1.BoPlanningSystem PlanningSystem { get; set; }
        public SAPB1.BoProcurementMethod ProcurementMethod { get; set; }
        public SAPB1.BoMRPComponentWarehouse ComponentWarehouse { get; set; }
        public Edm.Int32 OrderIntervals { get; set; }
        public Edm.Double OrderMultiple { get; set; }
        public Edm.Int32 LeadTime { get; set; }
        public Edm.Double MinOrderQuantity { get; set; }
        public SAPB1.ItemTypeEnum ItemType { get; set; }
        public SAPB1.ItemClassEnum ItemClass { get; set; }
        public Edm.Int32 OutgoingServiceCode { get; set; }
        public Edm.Int32 IncomingServiceCode { get; set; }
        public Edm.Int32 ServiceGroup { get; set; }
        public Edm.Int32 NCMCode { get; set; }
        public SAPB1.BoMaterialTypes MaterialType { get; set; }
        public Edm.Int32 MaterialGroup { get; set; }
        public Edm.String ProductSource { get; set; }
        public SAPB1.BoYesNoEnum Properties1 { get; set; }
        public SAPB1.BoYesNoEnum Properties2 { get; set; }
        public SAPB1.BoYesNoEnum Properties3 { get; set; }
        public SAPB1.BoYesNoEnum Properties4 { get; set; }
        public SAPB1.BoYesNoEnum Properties5 { get; set; }
        public SAPB1.BoYesNoEnum Properties6 { get; set; }
        public SAPB1.BoYesNoEnum Properties7 { get; set; }
        public SAPB1.BoYesNoEnum Properties8 { get; set; }
        public SAPB1.BoYesNoEnum Properties9 { get; set; }
        public SAPB1.BoYesNoEnum Properties10 { get; set; }
        public SAPB1.BoYesNoEnum Properties11 { get; set; }
        public SAPB1.BoYesNoEnum Properties12 { get; set; }
        public SAPB1.BoYesNoEnum Properties13 { get; set; }
        public SAPB1.BoYesNoEnum Properties14 { get; set; }
        public SAPB1.BoYesNoEnum Properties15 { get; set; }
        public SAPB1.BoYesNoEnum Properties16 { get; set; }
        public SAPB1.BoYesNoEnum Properties17 { get; set; }
        public SAPB1.BoYesNoEnum Properties18 { get; set; }
        public SAPB1.BoYesNoEnum Properties19 { get; set; }
        public SAPB1.BoYesNoEnum Properties20 { get; set; }
        public SAPB1.BoYesNoEnum Properties21 { get; set; }
        public SAPB1.BoYesNoEnum Properties22 { get; set; }
        public SAPB1.BoYesNoEnum Properties23 { get; set; }
        public SAPB1.BoYesNoEnum Properties24 { get; set; }
        public SAPB1.BoYesNoEnum Properties25 { get; set; }
        public SAPB1.BoYesNoEnum Properties26 { get; set; }
        public SAPB1.BoYesNoEnum Properties27 { get; set; }
        public SAPB1.BoYesNoEnum Properties28 { get; set; }
        public SAPB1.BoYesNoEnum Properties29 { get; set; }
        public SAPB1.BoYesNoEnum Properties30 { get; set; }
        public SAPB1.BoYesNoEnum Properties31 { get; set; }
        public SAPB1.BoYesNoEnum Properties32 { get; set; }
        public SAPB1.BoYesNoEnum Properties33 { get; set; }
        public SAPB1.BoYesNoEnum Properties34 { get; set; }
        public SAPB1.BoYesNoEnum Properties35 { get; set; }
        public SAPB1.BoYesNoEnum Properties36 { get; set; }
        public SAPB1.BoYesNoEnum Properties37 { get; set; }
        public SAPB1.BoYesNoEnum Properties38 { get; set; }
        public SAPB1.BoYesNoEnum Properties39 { get; set; }
        public SAPB1.BoYesNoEnum Properties40 { get; set; }
        public SAPB1.BoYesNoEnum Properties41 { get; set; }
        public SAPB1.BoYesNoEnum Properties42 { get; set; }
        public SAPB1.BoYesNoEnum Properties43 { get; set; }
        public SAPB1.BoYesNoEnum Properties44 { get; set; }
        public SAPB1.BoYesNoEnum Properties45 { get; set; }
        public SAPB1.BoYesNoEnum Properties46 { get; set; }
        public SAPB1.BoYesNoEnum Properties47 { get; set; }
        public SAPB1.BoYesNoEnum Properties48 { get; set; }
        public SAPB1.BoYesNoEnum Properties49 { get; set; }
        public SAPB1.BoYesNoEnum Properties50 { get; set; }
        public SAPB1.BoYesNoEnum Properties51 { get; set; }
        public SAPB1.BoYesNoEnum Properties52 { get; set; }
        public SAPB1.BoYesNoEnum Properties53 { get; set; }
        public SAPB1.BoYesNoEnum Properties54 { get; set; }
        public SAPB1.BoYesNoEnum Properties55 { get; set; }
        public SAPB1.BoYesNoEnum Properties56 { get; set; }
        public SAPB1.BoYesNoEnum Properties57 { get; set; }
        public SAPB1.BoYesNoEnum Properties58 { get; set; }
        public SAPB1.BoYesNoEnum Properties59 { get; set; }
        public SAPB1.BoYesNoEnum Properties60 { get; set; }
        public SAPB1.BoYesNoEnum Properties61 { get; set; }
        public SAPB1.BoYesNoEnum Properties62 { get; set; }
        public SAPB1.BoYesNoEnum Properties63 { get; set; }
        public SAPB1.BoYesNoEnum Properties64 { get; set; }
        public SAPB1.BoYesNoEnum AutoCreateSerialNumbersOnRelease { get; set; }
        public Edm.Int32 DNFEntry { get; set; }
        public Edm.String GTSItemSpec { get; set; }
        public Edm.String GTSItemTaxCategory { get; set; }
        public Edm.Int32 FuelID { get; set; }
        public Edm.String BeverageTableCode { get; set; }
        public Edm.String BeverageGroupCode { get; set; }
        public Edm.Int32 BeverageCommercialBrandCode { get; set; }
        public Edm.Int32 Series { get; set; }
        public Edm.Int32 ToleranceDays { get; set; }
        public SAPB1.TypeOfAdvancedRulesEnum TypeOfAdvancedRules { get; set; }
        public SAPB1.IssuePrimarilyByEnum IssuePrimarilyBy { get; set; }
        public SAPB1.BoYesNoEnum NoDiscounts { get; set; }
        public Edm.String AssetClass { get; set; }
        public Edm.String AssetGroup { get; set; }
        public Edm.String InventoryNumber { get; set; }
        public Edm.Int32 Technician { get; set; }
        public Edm.Int32 Employee { get; set; }
        public Edm.Int32 Location { get; set; }
        public SAPB1.AssetStatusEnum AssetStatus { get; set; }
        public Edm.DateTime CapitalizationDate { get; set; }
        public SAPB1.BoYesNoEnum StatisticalAsset { get; set; }
        public SAPB1.BoYesNoEnum Cession { get; set; }
        public SAPB1.BoYesNoEnum DeactivateAfterUsefulLife { get; set; }
        public SAPB1.BoYesNoEnum ManageByQuantity { get; set; }
        public Edm.Int32 UoMGroupEntry { get; set; }
        public Edm.Int32 InventoryUoMEntry { get; set; }
        public Edm.Int32 DefaultSalesUoMEntry { get; set; }
        public Edm.Int32 DefaultPurchasingUoMEntry { get; set; }
        public Edm.String DepreciationGroup { get; set; }
        public Edm.String AssetSerialNumber { get; set; }
        public Edm.Double InventoryWeight { get; set; }
        public Edm.Int32 InventoryWeightUnit { get; set; }
        public Edm.Double InventoryWeight1 { get; set; }
        public Edm.Int32 InventoryWeightUnit1 { get; set; }
        public Edm.String DefaultCountingUnit { get; set; }
        public Edm.Double CountingItemsPerUnit { get; set; }
        public Edm.Int32 DefaultCountingUoMEntry { get; set; }
        public SAPB1.BoYesNoEnum Excisable { get; set; }
        public Edm.Int32 ChapterID { get; set; }
        public Edm.String ScsCode { get; set; }
        public SAPB1.SpecialProductTypeEnum SpProdType { get; set; }
        public Edm.Double ProdStdCost { get; set; }
        public SAPB1.BoYesNoEnum InCostRollup { get; set; }
        public SAPB1.BoYesNoEnum VirtualAssetItem { get; set; }
        public SAPB1.BoYesNoEnum EnforceAssetSerialNumbers { get; set; }
        public Edm.Int32 AttachmentEntry { get; set; }
        public Edm.String LinkedResource { get; set; }
        public Edm.DateTime UpdateDate { get; set; }
        public Edm.Time UpdateTime { get; set; }
        public SAPB1.BoYesNoEnum GSTRelevnt { get; set; }
        public Edm.Int32 SACEntry { get; set; }
        public SAPB1.GSTTaxCategoryEnum GSTTaxCategory { get; set; }
        public Edm.Int32 ServiceCategoryEntry { get; set; }
        public Edm.Double CapitalGoodsOnHoldPercent { get; set; }
        public Edm.Double CapitalGoodsOnHoldLimit { get; set; }
        public Edm.Double AssessableValue { get; set; }
        public Edm.Double AssVal4WTR { get; set; }
        public SAPB1.SOIExcisableTypeEnum SOIExcisable { get; set; }
        public Edm.String TNVED { get; set; }
        public SAPB1.BoYesNoEnum ImportedItem { get; set; }
        public Edm.Int32 PricingUnit { get; set; }
        public Edm.DateTime CreateDate { get; set; }
        public Edm.Time CreateTime { get; set; }
        public Edm.String NVECode { get; set; }
        public Edm.Double CtrSealQty { get; set; }
        public Edm.Int32 CESTCode { get; set; }
        public Edm.String LegalText { get; set; }
        public Edm.Int32 DataVersion { get; set; }
        public Edm.String CreateQRCodeFrom { get; set; }
        public SAPB1.BoYesNoEnum TraceableItem { get; set; }
        public Edm.Int32 CommodityClassification { get; set; }
        public Edm.String U_B1SYS_IPIStamp { get; set; }
        public Edm.Int32 U_B1SYS_ItmClssC { get; set; }
        public Edm.String U_B1SYS_FedServC { get; set; }
        public Edm.String U_B1SYS_TaxUoMBS { get; set; }
        public Edm.Double U_B1SYS_QtyPerTaxUoM { get; set; }
        public Edm.String U_B1SYS_TaxUoM { get; set; }
        public Edm.Double U_B1SYS_IVAST { get; set; }
        public Edm.String U_B1SYS_IPIClssC { get; set; }
        public Edm.String U_B1SYS_SPEDItSerCod { get; set; }
        public Edm.Double U_B1SYS_SPEDICMSRate { get; set; }
        public Edm.String U_B1SYS_SPEDTipi { get; set; }
        public Edm.Double U_TX_AliqIcms { get; set; }
        public Edm.String U_TX_ExIpi { get; set; }
        public Edm.String U_TX_CodAtivEcon { get; set; }
        public Edm.Int32 U_TX_TipoUtilizacao { get; set; }
        public Edm.String U_TX_ProdGnre { get; set; }
        public Edm.String U_TX_cBarra { get; set; }
        public Edm.String U_TX_cBarraTrib { get; set; }
        public Edm.String U_TX_TipoMedicamento { get; set; }
        public Edm.String U_TX_IndCreditoEst { get; set; }
        public Edm.String U_TX_TipoIsencao { get; set; }
        public Edm.String U_TX_CodAnvi { get; set; }
        public Edm.String U_TX_MotAnvi { get; set; }
        public Edm.String U_TX_UTrib { get; set; }
        public Edm.Double U_TX_FatorTrib { get; set; }
        public Edm.String U_TX_PerUnTrib { get; set; }
        public Edm.String U_TX_CodEANTrib { get; set; }
        public Edm.String U_TX_UTribEx { get; set; }
        public Edm.Double U_TX_FtTribEx { get; set; }
        public Edm.String U_TX_CEANTribEx { get; set; }
        public Edm.String U_TX_CodigoCest { get; set; }
        public Edm.String U_TX_BenefDL288_67 { get; set; }
        public Edm.String U_TX_NDCRE { get; set; }
        public Edm.String U_U_SEIDOR_FAMILIA { get; set; }
        public Edm.String U_AGRT_GrpItem { get; set; }
        public Edm.String U_AGRT_MultiEmb { get; set; }
        public Edm.Int32 U_AGRT_InstAddon { get; set; }
        public Edm.String U_AGRC_GRPEQUIV { get; set; }
        public Edm.Double U_AGRT_Margem { get; set; }
        public Edm.String U_AGRT_ExclusivoNota { get; set; }
        public Edm.Double U_AGRT_EqvKlLt { get; set; }
        public Edm.String U_AGRT_UUID_SEM { get; set; }
        public Edm.String U_AGRT_FltCampoUsu { get; set; }
        public Edm.Double U_AGRC_LimPercDesconto { get; set; }
        public Edm.String U_AGRC_CodigoSifRj { get; set; }
        public Edm.String U_AGRC_CodigoSifGo { get; set; }
        public Edm.String U_TX_RF_Serv { get; set; }
        public List<SAPB1.ItemPrice> ItemPrices { get; set; }
        public List<SAPB1.ItemWarehouseInfo> ItemWarehouseInfoCollection { get; set; }
        public List<SAPB1.ItemPreferredVendor> ItemPreferredVendors { get; set; }
        public List<SAPB1.ItemLocalizationInfo> ItemLocalizationInfos { get; set; }
        public List<SAPB1.ItemProject> ItemProjects { get; set; }
        public List<SAPB1.ItemDistributionRule> ItemDistributionRules { get; set; }
        public List<SAPB1.ItemAttributeGroups> ItemAttributeGroups { get; set; }
        public List<SAPB1.ItemDepreciationParameter> ItemDepreciationParameters { get; set; }
        public List<SAPB1.ItemPeriodControl> ItemPeriodControls { get; set; }
        public List<SAPB1.ItemUnitOfMeasurement> ItemUnitOfMeasurementCollection { get; set; }
        public List<SAPB1.ItemBarCode> ItemBarCodeCollection { get; set; }
        public SAPB1.ItemIntrastatExtension ItemIntrastatExtension { get; set; }
    }
}
