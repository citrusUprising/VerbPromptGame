-> CasinoAccount

== CasinoAccount  ==
Casino’s Account
While checking whether the casino was operating in compliance, some unusual records were discovered, and it seemed that someone had tampered with the accounts.

-> who_to_question
= who_to_question

{who_to_question > 2:
    -> END
}

{Who will you ask about this?|Who else will you ask about this?}

* Mrs. Emerson
    -> mrs_emerson

* Alec
    -> alec

* Quinten
    -> quinten

= mrs_emerson
What will you ask her?

* "How is the casino doing?"
    "I'm not involved in the casino operations, and I don't want to be involved. I told him to be careful, but he was always so arrogant and thought that no one could fool him."
    -> who_to_question
* "There is a problem with the casino account, did you know?"
    "What? I knew it! He must not have checked his accounts recently. A person like him must not believe that someone can deceive him under his nose. He is always so confident."
    -> who_to_question

= alec
What will you ask him?

* "How is the casino doing?"
    "Very good, the daily turnover is far beyond imagination. Other casinos have been trying to surpass us, and they even had reason to kill Mr.Emerson."
    -> who_to_question
* "Did you just come from another casino? Do you know the operating situation of other casinos?"
    "Yes, I came to this casino two months ago. As for the revenue of other casinos, I am just a dealer, so how can I have access to this level?"
    -> who_to_question

= quinten
What will you ask him?

* "As a senior manager, you should be familiar with the casino's accounts, right?"
    "Yes, the accounts were reviewed by me and Mr.Emerson, and the revenue has dropped slightly in the last two months, I think because of the fierce competition from other casinos."
    -> who_to_question
* "How do you and Mr.Emerson work together? Who is in charge of the accounts?"
    "I am responsible for the human resources of the casino, and he is more responsible for management, but he has rarely been involved in the past two years. The accounts were reviewed by Mr.Emerson and I. In the past two months, the income has dropped. I don’t know if it’s because his wife has been unusual recently."
    -> who_to_question