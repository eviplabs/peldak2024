# Adatkötésnél mikre érdemes figyelni?

- Ha valaminek változik az értéke, PropertyChanged esemény keletkezik?
- Ha listát akarsz adatkötni, használj ObservableCollection-t, mivel az jelzi, ha például új elem kerül bele.

Adatkötni MAUI alatt csak propertyhez tudsz.
Ha másik control-hoz kötsz, állítsd be azt BindingContext-nek
A code behindban az InitializeComponents hívás előtt állítsd be a BindingContext-et (tipikusan this-re).
