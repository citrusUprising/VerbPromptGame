-> BloodTrace

== BloodTrace ==
Blood Trace
There were spurts of blood on the desk and the wall. In addition, there were continuous drops of blood on the floor, extending from the desk to near the door.

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

* "Do you have anything to say about this?"
    "Oh my gosh, don't tell me this, I feel so sick."
    -> who_to_question

= alec
What will you ask him?

* "You have blood on your sleeve, what do you have to say about it?"
    "I tested his breath to make sure he was still alive. Isn't it normal for him to be stained with blood?"
    -> who_to_question

= quinten
What will you ask him?

* "You seem surprised by this. Is there anything you want to say?"
    "No, I was just wondering who he could trust enough to bring a gun in."
    -> who_to_question