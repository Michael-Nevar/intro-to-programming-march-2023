namespace Status;

public record class StatusMessage(Guid Id, string Message, DateTimeOffset When);