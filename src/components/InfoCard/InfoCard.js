import React from 'react'
import styles from './InfoCard.module.css'

export default function InfoCard({ number, text, variant, Icon }) {
  switch (variant) {
		case 'green':
			return (
				<div className={`${styles.card} ${styles.green}`}>
					<div className={styles.content}>
						<p className={styles.number}>{number}</p>
						<p className={styles.text}>{text}</p>
					</div>
					<Icon />
				</div>
			)
			break

		case 'blue':
			return (
				<div className={`${styles.card} ${styles.blue}`}>
					<div className={styles.content}>
						<p className={styles.number}>{number}</p>
						<p className={styles.text}>{text}</p>
					</div>
					<Icon />
				</div>
			)
			break

		case 'orange':
			return (
				<div className={`${styles.card} ${styles.orange}`}>
					<div className={styles.content}>
						<p className={styles.number}>{number}</p>
						<p className={styles.text}>{text}</p>
					</div>
					<Icon />
				</div>
			)
			break

		case 'yellow':
			return (
				<div className={`${styles.card} ${styles.yellow}`}>
					<div className={styles.content}>
						<p className={styles.number}>{number}</p>
						<p className={styles.text}>{text}</p>
					</div>
					<Icon />
				</div>
			)
			break

		default:
			return (
				<div className={styles.card}>
					<div className={styles.content}>
						<p className={styles.number}>{number}</p>
						<p className={styles.text}>{text}</p>
					</div>
					<Icon />
				</div>
			)
			break
	}
}
