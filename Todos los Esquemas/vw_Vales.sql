USE [SARE]
GO

/****** Object:  View [dbo].[view_Vales]    Script Date: 3/23/2017 2:11:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_Vales]
AS
SELECT        dbo.tab_Vales.vale_Id, dbo.tab_Vales.vale_Fecha, dbo.tab_Vales.vale_Requirio, dbo.tab_Vales.wo_Id, dbo.tab_Vales.vale_Estado, dbo.tab_ValesDetalle.prod_Id, 
                         dbo.tab_ValesDetalle.valeD_Cantidad, dbo.tab_ValesDetalle.valeD_Entregado, dbo.tab_ValesDetalle.valeD_Id, dbo.cat_Productos.prod_ClaveFabricante, 
                         dbo.cat_Productos.prod_ClaveProducto, dbo.cat_Productos.prod_Producto, dbo.cat_Unidades.unidad_Descripcion, dbo.cat_Productos.prod_Precio
FROM            dbo.tab_Vales INNER JOIN
                         dbo.tab_ValesDetalle ON dbo.tab_Vales.vale_Id = dbo.tab_ValesDetalle.vale_Id INNER JOIN
                         dbo.cat_Productos ON dbo.tab_ValesDetalle.prod_Id = dbo.cat_Productos.prod_Id INNER JOIN
                         dbo.cat_Unidades ON dbo.cat_Productos.unidad_Id = dbo.cat_Unidades.unidad_Id

GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[23] 2[3] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tab_Vales"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 167
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tab_ValesDetalle"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 176
               Right = 423
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cat_Productos"
            Begin Extent = 
               Top = 6
               Left = 461
               Bottom = 198
               Right = 737
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cat_Unidades"
            Begin Extent = 
               Top = 6
               Left = 775
               Bottom = 118
               Right = 968
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 4110
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Vales'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'= 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Vales'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Vales'
GO

