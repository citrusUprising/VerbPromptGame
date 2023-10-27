-> Gun

== Gun ==
Gun
A gun was found at the scene. After comparing the shell and gun model, it was confirmed to be the murder weapon.

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

* "Do you recognize this gun?"
    "This is my hunsband’s gun."
    -> who_to_question
* "Who could enter his office with a gun?"
    "I always hate guns. Casino has strict rules by Mr.Emerson, the security should not let any gun enter his office but…I do not know if it also works for Quinten."
    -> who_to_question

= alec
What will you ask him?

* "Do you recognize this gun?"
    "I don’t. What? Is this the murder weapon?"
    -> who_to_question
* "Who could enter his office with a gun?"
    "I have no idea, I passed the security check. I come here for work, not to kill."
    -> who_to_question

= quinten
What will you ask him?

* "Do you recognize this gun?"
    "This is Mr.Emerson's gun and should be kept in a locked drawer on his desk."
    -> who_to_question
* "Who could enter his office with a gun?"
    "It’s impossible to carry a gun except Mr.Emerson."
    -> who_to_question