﻿namespace Shared.Models;

public record PromptResponse(string Prompt, string Response, bool IsComplete = false);
