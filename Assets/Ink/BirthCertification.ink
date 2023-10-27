== BirthCertification ==
Birth Certification
A yellowed paper found in Mr.Emerson’s office.
Mr.and Mrs.Emerson’s son. Born on August 13th, 1921.


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

* "Do you have a child?"
    "This is our first child, but I lost him a long time ago (in sorrow)."
    -> who_to_question
* "Where’s he?"
    "(In sorrow) I really regret not insisting on taking my son with me when that thing happens…"
    -> who_to_question

= alec
What will you ask him?

* "Does Mr.and Mrs.Emerson have a child?"
    "Oh, they have a child? I never heard about it."
    -> who_to_question
* "Where’s he?"
    "Hey I don’t even know they have a son."
    -> who_to_question

= quinten
What will you ask him?

* "Does Mr.and Mrs.Emerson have a child?"
    "They once had a son, this was a long time ago… That thing happened and I became Mr.Emerson’s best friend."
    -> who_to_question
* "Where’s he?"
    "This was a hard time. Mr.Emerson might have made a wrong decision. He was left behind when mobs chased Emerson’s family."
    -> who_to_question