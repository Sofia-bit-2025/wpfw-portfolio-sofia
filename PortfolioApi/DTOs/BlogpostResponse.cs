
namespace PortfolioApi.DTOs;

public sealed record BlogpostResponse(
    int Id,
    string Titel,
    string Inhoud,
    DateOnly Publicatiedatum
);
