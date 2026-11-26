# TallerTech

Sistema de gestión para un taller mecánico.

Hecho en C# (WinForms, .NET Framework 4.7.2) con SQL Server y Entity Framework 6 (.edmx).

## Estructura (3 capas)

- Datos: acceso a la base de datos con Entity Framework (clases D*).
- Negocio: reglas y validaciones (clases N*).
- Presentacion: formularios de Windows (Frm*).
- TallerMecanico.sql: script de la base de datos con datos de prueba.
- Accesos.txt: usuarios de prueba (admin y recepcion).

## Cómo ejecutarlo

1. Ejecutar TallerMecanico.sql en SQL Server.
2. En Presentacion/App.config, cambiar `data source` por el servidor de tu equipo.
3. Abrir la solución en Visual Studio, poner Presentacion como proyecto de inicio y ejecutar.

## Roles

- Administrador: acceso a todo.
- Recepcionista: no puede registrar mecánicos ni repuestos, ni ver reportes de ingresos ni de mecánicos.

## Requerimientos funcionales y archivos

| RF | Descripción | Formulario | Negocio / Datos |
|----|-------------|-----------|-----------------|
| RF-01 | Clientes y vehículos | FrmCliente, FrmVehiculo | NCliente, NVehiculo / DCliente, DVehiculo |
| RF-02 | Órdenes de servicio | FrmOrdenServicio | NOrdenServicio / DOrdenServicio |
| RF-03 | Repuestos e inventario (alerta de stock) | FrmRepuesto, FrmGestionOrden | NRepuesto, NDetalleRepuesto / DRepuesto, DDetalleRepuesto |
| RF-04 | Total de la orden | FrmGestionOrden | NDetalleRepuesto / DOrdenServicio |
| RF-05 | Estados de la orden | FrmGestionOrden, FrmConsultaOrdenes | NOrdenServicio / DOrdenServicio |
| RF-06 | Reporte de ingresos (gráficos) | FrmResumenIngresos | NOrdenServicio / DOrdenServicio |
| RF-07 | Reporte de inventario y rotación | FrmConsultaRepuestos | NRepuesto / DRepuesto |
| RF-08 | Reporte de órdenes por mecánico | FrmReporteMecanico | NOrdenServicio / DOrdenServicio |
| RF-09 | Historial del vehículo y cliente | FrmHistorialVehiculo | NOrdenServicio, NVehiculo / DOrdenServicio |
| RF-10 a RF-20 | Pendientes | | |

Otros archivos: FrmLogin (acceso por usuario y rol), Form1 (menú principal), FrmMecanico (registro de mecánicos).

## Ramas

- main: versión estable para entregar.
