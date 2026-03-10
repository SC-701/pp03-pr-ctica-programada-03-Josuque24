CREATE PROCEDURE [dbo].[ObtenerModelo]
    @Id uniqueidentifier
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        m.Id,
        m.IdMarca,
        m.Nombre
    FROM dbo.Modelos m
    WHERE m.IdMarca = @Id;
END