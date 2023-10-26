== shouts ==
Shouts
There were reports of shouts right before the sound of gunshots on the night of the crime.

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
{What will you ask her?|What will you ask her?|}

* "Did Mr. Emerson have a temper?"
    "My husband was a very well composed man, though sometimes he would falter. He has lost his temper a few times with me."
    -> mrs_emerson
* "Did work frustrate your husband?"
    "Yes, he would often come home from work grumbling about what he had to deal with that day."
    -> mrs_emerson

* -> who_to_question

= alec
{What will you ask him?|What will you ask him?|}
* "Did Mr. Emerson ever yell at you?"
    "Never, but I have heard stories about people who get on his bad side. He really knows how to tear into someone."
    -> alec
* "Did you know what would set Mr. Emerson off?"
    "Yeah, he would go off on people for coming in late or leaving too early. He was always trying to have people pick up more slack."
    -> alec

* -> who_to_question

= quinten
{What will you ask him?|What will you ask him?|}

* "Did Mr. Emerson ever yell at you?"
    "No. We were always on good terms. He only ever had kind words for me."
    -> quinten
* "Did you hear the shouts?"
    "No, I was downstairs at the time so I didn’t hear anything. If I had heard the shouts, I would have assumed that a rookie showed up late or something."
    -> quinten

* -> who_to_question