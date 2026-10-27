CREATE TABLE [dbo].[CuotasComprobantes] (
    [IdCuota] INT IDENTITY(1,1) NOT NULL,
    [IdComprobante] INT NOT NULL,
    [NumeroCuota] INT NOT NULL,
    [MontoBase] DECIMAL(18,2) NOT NULL,
    [PorcentajeInteres] DECIMAL(18,2) NOT NULL,
    [MontoInteres] DECIMAL(18,2) NOT NULL,
    [FechaVencimiento] DATETIME2 NOT NULL,
    [Pagada] BIT NOT NULL,
    CONSTRAINT [PK_CuotasComprobantes] PRIMARY KEY CLUSTERED ([IdCuota] ASC),
    CONSTRAINT [FK_CuotasComprobantes_Comprobantes_IdComprobante] FOREIGN KEY ([IdComprobante]) 
        REFERENCES [dbo].[Comprobantes] ([IdComprobante]) ON DELETE CASCADE
);