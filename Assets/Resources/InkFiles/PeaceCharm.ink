-> PeaceCharm

== PeaceCharm ==
Peace Charm
Waiter at casino: I accidentally spilled wine on Alec's shirt before, and I saw something similar to a circle on his chest. Is it a peace charm? I don't know, maybe it’s something else.

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

* "Do you know there's a dealer named Alec who works for Mr.Emerson’s?"
    "There are so many people coming and going at the casino that I don't know most of them and don't go there often."
    -> who_to_question
* "Have you ever seen an approximately round amulet?"
    "No, I don't believe in this."
    -> who_to_question

= alec
What will you ask him?

* "You seem to be wearing an amulet every day? Does it mean anything to you?"
    "Amulet? I don't have this thing. Officer, how many useless questions are you going to ask?"
    -> who_to_question
* "We are going to search you, please cooperate."
    "Hey, is this part of the program? I didn't do anything.
    (search)
    Let’s just say, there’s nothing, I didn’t do anything.
"
    -> who_to_question

= quinten
What will you ask him?

* "How much do you know about Alec?"
    "Alec? I know he is the dealer of the casino, but I don’t know much else."
    -> who_to_question
* "Have you ever seen a round amulet in a casino?"
    "I seem to have heard someone mention it. I also told Mr. Emerson that we need to strengthen management recently and not allow these people to gossip at will. It would be bad if something is revealed that should not be said."
    -> who_to_question