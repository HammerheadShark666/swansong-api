using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record MessageResponse(List<Message> Messages);

public record Message(string Text, string Severity); 