CREATE OR REPLACE FUNCTION setDateUpdate()
RETURNS TRIGGER AS $$
BEGIN
    NEW.date_update := NOW();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION setDateCreation()
RETURNS TRIGGER AS $$
BEGIN
    NEW.date_creation := NOW();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;