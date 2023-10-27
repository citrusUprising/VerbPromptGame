-> BulletShell

== BulletShell ==
Bullet Shell
Two shell casings were found in the office, and one bullet hole was found near the door and another one found on the opposite wall.

-> who_to_question
= who_to_question

{who_to_question > 1:
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

* "Has there ever been a shooting here?"
    "No, at least I don't know of one. He doesn't usually hold a gun."
    -> who_to_question

= alec
What will you ask him?

* "Has there ever been a shooting here?"
    "I just came here not too long ago and I haven't heard of any shootings happening in the office."
    -> who_to_question

= quinten
What will you ask him?

* "Has there ever been a shooting here?"
    "I can’t remember clearly, maybe it happened a few years ago."
    -> who_to_question