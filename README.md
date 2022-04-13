# CreditSuisse

Question 2: A new category was created called PEP (politically exposed person). Also, a new bool property IsPoliticallyExposed was created in the ITrade interface. A trade shall be categorized as PEP if IsPoliticallyExposed is true. Describe in at most 1 paragraph what you must do in your design to account for this new category.

Answer: I would create a new category class called "PepCategory" and will adapt Enums, Trade and TradeProcessor classes to that new property
