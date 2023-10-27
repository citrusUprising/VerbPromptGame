== Calendar  ==
Calendar
Found a calendar in the office with a meeting in red circle at 10pm for 30 min.

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

* "Mr. Emerson has an appointment with someone tonight, do you know who it is?"
    "I don't know, but he looked excited."
    -> who_to_question
* "Did work frustrate your husband?"
    "Nothing special, I just wanted to hang out."
    -> who_to_question

= alec
What will you ask him?

* "Mr. Emerson has an appointment with someone tonight, do you know who it is?"
    "It's me. He said he would check my performance tonight. I guess he was going to give me a raise."
    -> who_to_question
* "Where were you at 10pm? Are you staying with Mr.Emerson?"
    "Mr.Emerson asked me to meet at ten o'clock. I guess he wanted to give me a raise, but I arrived ten minutes late. When I walked in, I saw that he was not breathing."
    -> who_to_question

= quinten
What will you ask him?

* "Mr. Emerson has an appointment with someone tonight, do you know who it is?"
    "It must be Alec. When we checked the accounts two days ago, we decided to give this young man a salary increase."
    -> who_to_question
* "Where were you at 10pm? "
    "Where else can I be? I was sorting out information in my office. The competition in the casino business has been fierce recently, and I want to help my best friend make more money."
    -> who_to_question