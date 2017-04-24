USE [SARE]
GO

/****** Object:  View [dbo].[view_cat_Productos]    Script Date: 3/23/2017 2:10:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_cat_Productos]
AS
SELECT        dbo.cat_Productos.prod_ClaveFabricante, dbo.cat_Productos.prod_ClaveProducto, dbo.cat_Productos.prod_Producto, dbo.cat_Productos.prod_Especificaciones, 
                         dbo.cat_Productos.unidad_Id, dbo.cat_Productos.prod_Maximo, dbo.cat_Productos.prod_Minimo, dbo.cat_Productos.prod_Existencias, 
                         dbo.cat_Productos.prod_Precio, dbo.cat_Productos.prod_Locacion, dbo.cat_Productos.prod_Fecha, dbo.cat_Productos.prod_Activo, 
                         dbo.cat_Productos.prod_CantidadPendiente, dbo.cat_Productos.clasificacion_Id, dbo.cat_Productos.prod_ConMovimientos, dbo.cat_Productos.prod_DiasparaSurtir, 
                         dbo.cat_Productos.prod_ULTIMO_PROVEEDOR, dbo.cat_Productos.prod_ULTIMA_FECHACOMPRA, dbo.cat_Productos.prod_COSTOTOTALMOVIMIENTOS, 
                         dbo.cat_Productos.prod_OPTIMO, dbo.cat_Productos.prod_TOTALENTRADAS, dbo.cat_Productos.prod_TOTALSALIDAS, dbo.cat_Productos.prod_PROMEDIO, 
                         dbo.cat_Productos.prod_RutaImagen, dbo.cat_Productos.prod_Id, dbo.cat_Clasificacion.clasificacion_Descripcion, dbo.cat_Unidades.unidad_Descripcion, 
                         dbo.cat_Imagenes.imagenes_ruta, dbo.cat_Productos.prod_Fabricante
FROM            dbo.cat_Productos LEFT OUTER JOIN
                         dbo.cat_Clasificacion ON dbo.cat_Clasificacion.clasificacion_Id = dbo.cat_Productos.clasificacion_Id LEFT OUTER JOIN
                         dbo.cat_Unidades ON dbo.cat_Unidades.unidad_Id = dbo.cat_Productos.unidad_Id LEFT OUTER JOIN
                         dbo.cat_Imagenes ON dbo.cat_Imagenes.imagenes_Id = dbo.cat_Productos.prod_RutaImagen

GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[18] 4[72] 2[4] 3) )"
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
         Begin Table = "cat_Productos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 314
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cat_Clasificacion"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 250
               Right = 259
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cat_Unidades"
            Begin Extent = 
               Top = 252
               Left = 38
               Bottom = 364
               Right = 231
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cat_Imagenes"
            Begin Extent = 
               Top = 138
               Left = 297
               Bottom = 250
               Right = 474
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
      Begin ColumnWidths = 10
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3600
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
   ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_cat_Productos'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'      Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_cat_Productos'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_cat_Productos'
GO

