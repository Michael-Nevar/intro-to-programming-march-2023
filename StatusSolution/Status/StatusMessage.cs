namespace Status;

public record class StatusMessage(Guid Id, string currentMessage, DateTimeOffset When);