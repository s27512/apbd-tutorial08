namespace apbd_tutorial08.Application.DTOs;

public class TripDto
{
    public required string Name { get; set; } = string.Empty;
    public required string Description { get; set; } = string.Empty;
    public required DateTime DateFrom { get; set; }
    public required DateTime DateTo { get; set; }
    public required int MaxPeople { get; set; }
    public required List<CountryDto> Countries { get; set; } = [];
    public required List<ClientDto> Clients { get; set; } = [];
}