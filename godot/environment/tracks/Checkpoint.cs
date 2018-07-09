using Godot;

/// <summary>
/// Class representing a checkpoint: a fixed point in the track used to evaluate the cars genotype. More
/// in detail, the set of checkpoint on the track helps to calculate the distance traveled by each car, hence
/// the evaluation of their genotypes.
/// </summary>
public class Checkpoint : Node2D
{
    /// <value>The score associated to the checkpoint, used in the evaluation phase.</value>
    public double Score
    {
        get;
        set;
    }
}
