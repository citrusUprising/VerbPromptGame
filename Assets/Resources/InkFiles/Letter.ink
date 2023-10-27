-> Letter

== Letter ==
Letter from Mr.Emerson’s Body
He was shot in the chest, his hands were covered in blood, and an old letter stained with blood was found on his body. 

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

* "Some words are blurred. Can you identify them? "
    "This letter from my husband's family. We read it together before. Something very sad has happened and I'm so sorry. After I drank once, the child got up again and asked his parents, he wanted to find you. You told me that when it was safe, you would take him away yourself. I angrily hit him and he ran to the door of the house. I'm trying to find him."
    -> who_to_question

= alec
What will you ask him?

* "Some words are blurred. Can you identify them?"
    "Officer, this paper was soaked with blood. I couldn't see anything except the signature Emerson at the bottom."
    -> who_to_question

= quinten
What will you ask him?

* "Some words are blurred. Can you identify them?"
    "I can’t clearly read it. But it looks like about Mr.Emerson’s first child lost. He was in great sorrow that night he received this message and Mrs.Emerson was so angry with him and we drank a lot."
    -> who_to_question