== Text ==
Text between Mrs.Emerson and Quinten
A photo of the lock screen of Mrs.'s cell phone was found in the folder, and one of the prompts contained a text message sent by Quinten to Mrs. Emerson. It read, "Don't worry. He would not know. Kid is in safe… "

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

* "How is this going?"
    "Some time ago, Quinten said that he had whereabouts of my child. I asked him to help me find a detective to continue the investigation. Where did this photo come from?
    (Found in the office)
    I believe Mr. Emerson is equally worried about our child."
    -> who_to_question

= alec
What will you ask him?

* "Have you seen this photo?"
    "What? ? Mrs.Emerson and Quinten have a child? This is big news. I'm going to have a chat with Mr. Quinten."
    -> who_to_question

= quinten
What will you ask him?

* "How is this going?"
    "What else could be going on? I'm just helping my best friend find his child. Mrs.Emerson does not want him to know because they have tried many years and she does not want him disappointed again."
    -> who_to_question