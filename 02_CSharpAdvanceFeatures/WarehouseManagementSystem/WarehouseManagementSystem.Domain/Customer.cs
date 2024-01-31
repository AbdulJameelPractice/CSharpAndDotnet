using System.Text.Json.Serialization;

namespace WarehouseManagementSystem.Domain;

public record Customer([property:JsonPropertyName("firstName")] string FirstName,[property:JsonPropertyName("lastName")] string LastName);