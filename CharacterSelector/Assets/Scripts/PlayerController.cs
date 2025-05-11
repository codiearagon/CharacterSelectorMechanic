using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI moveSpeedText;

    private Rigidbody2D rb;
    private SpriteRenderer spRenderer;
    private BoxCollider2D boxCollider;
    private float maxHealth;
    private float health;
    private float moveSpeed;

    private float horizontalInput;
    private float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();

        maxHealth = PlayerData.Instance.character.maxHealth;
        moveSpeed = PlayerData.Instance.character.moveSpeed;
        spRenderer.sprite = PlayerData.Instance.character.characterSprite;
        boxCollider.size = spRenderer.sprite.bounds.size;

        health = maxHealth;

        nameText.text = "Name: " + PlayerData.Instance.character.characterName;
        healthText.text = "Health: " + health;
        moveSpeedText.text = "Move Speed: " + moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        if(horizontalInput != 0 || verticalInput != 0)
            rb.linearVelocity = new Vector2(horizontalInput, verticalInput) * moveSpeed;
    }
}
