his merge was not fast-forward because after creating the feature-max branch,
a new commit was added directly on main (README) this means both branxches
had diverged, so Git had to create a merge commit to combine both histories


1.fast forward means no other commits were performed on targer branch, and merge commit when both branches were different
2.rebase rewritiong commits, so history will be more understandable, merge just creates commit
3. using rider merge tool just needed version was selected
