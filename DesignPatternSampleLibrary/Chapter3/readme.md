# Chapter 3 - Decorator

## Definition
- Attaches additional responsibilities to an object dynamically. Provide a flexible alternative to subclassing for extended functionality

## Textbook Details
- Referenced design principle (Open-Closed Princple): "Classes should be open for extension but closed for modification"
- Have the same supertype as the objects the decorate
- Can use one or more to wrap an object
- Key point: The decorator adds its own behavior either before and/or after delegating to the object it decorates to do the rest of the job
- Objects can be decorated at any time, so we can decorate objects dynamically at runtime with as many decorators as we want