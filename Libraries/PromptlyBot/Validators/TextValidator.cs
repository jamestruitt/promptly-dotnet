﻿using Microsoft.Bot.Builder;
using PromptlyBot.Validator;
using System;

namespace PromptlyBot.Validators
{
    public class TextValidator : Validator<string>
    {
        public override ValidatorResult<string> Validate(IBotContext context)
        {
            if ((context.Request.AsMessageActivity().Text != null) && (context.Request.AsMessageActivity().Text.Length > 0))
            {
                return new ValidatorResult<string>
                {
                    Value = context.Request.AsMessageActivity().Text
                };
            }
            else
            {
                return new ValidatorResult<string>
                {
                    Reason = "nottext"
                };
            }
        }
    }
}
