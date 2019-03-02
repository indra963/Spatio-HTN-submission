# Spatio - Hack The North 2018
Spatial training for patients with cognitive disorders.

# Inspiration
After learning about the potential of VR/AR in the medical field. We were interested in its applications as a cognitive tool in cases of Dementia and Alzheimers because studies have shown that rehabilitation of cognition is the most viable way of slowing down the effects of these diseases.

# What it does
Displays a puzzle in AR, which can be solved by moving the pieces of cardboard that the AR image is binded to.

# How we built it
We used Unity combined with Vuforia to setup the entire app. The phone was then attached to a Galaxy Gear VR.

# Challenges we ran into
The challenges we ran into were many, as Vuforia is not a very well documented framework, for cases which we were trying to tackle. We had originally started with ARCore, which is another framework, however we had to abandon it as it did not support muti-image tracking, whereas Vuforia did. The first major challenge that was brought upon us was to fix the jitteriness of the the AR images, which was the main reason ARCore was chosen before, however with linear interpolation, we were able to reduce the magnitude of jitteriness. Furthermore, our greatest hurdle was when we were supposed to isolate each AR images result from other image targets, as it was a strategy for us to determine if they puzzle was in the right position. At this point, we were even considering dropping the idea, as there was no documentation on it, but we later approached it with a different tactic of using distances.

# Accomplishments that we're proud of
We are proud about the fact that despite some setbacks, we were able to finish the project. But we are also proud of the time-management skills we gained due to experience those setbacks.

# What we learned
Important lesson we learnt was that never give up on your idea and be careful about using new technologies like A/R.

# What's next for Spatio
Adding more puzzle levels and improving the features of the app itself.
